using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Office.Interop.Outlook;
using Exception = System.Exception;

namespace AddToWunderlistForOutlook.Outlook
{
    public static class Helper
    {

        public static string GetSenderSmtpAddress(MailItem mail)
        {
            var PR_SMTP_ADDRESS = @"http://schemas.microsoft.com/mapi/proptag/0x39FE001E";
            if (mail == null)
            {
                throw new ArgumentNullException();
            }
            if (mail.SenderEmailType == "EX")
            {
                var sender = mail.Sender;
                if (sender != null)
                {
                    //Now we have an AddressEntry representing the Sender
                    if (sender.AddressEntryUserType == OlAddressEntryUserType.olExchangeUserAddressEntry
                        || sender.AddressEntryUserType == OlAddressEntryUserType.olExchangeRemoteUserAddressEntry)
                    {
                        //Use the ExchangeUser object PrimarySMTPAddress
                        var exchUser = sender.GetExchangeUser();
                        if (exchUser != null)
                        {
                            return exchUser.PrimarySmtpAddress;
                        }

                        return null;
                    }

                    return sender.PropertyAccessor.GetProperty(PR_SMTP_ADDRESS) as string;
                }

                return null;
            }

            return mail.SenderEmailAddress;
        }

        public static void AddUserProperty(MailItem mailitem, string ticketid)
        {
            UserProperties mailUserProperties = null;
            UserProperty mailUserProperty = null;
            try
            {
                mailUserProperties = mailitem.UserProperties;
                mailUserProperty = mailUserProperties.Add("KayakoTicketId", OlUserPropertyType.olText, true, 1);
                // Where 1 is OlFormatText (introduced in Outlook 2007) 
                mailUserProperty.Value = ticketid;
                mailitem.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (mailUserProperty != null) Marshal.ReleaseComObject(mailUserProperty);
                if (mailUserProperties != null) Marshal.ReleaseComObject(mailUserProperties);
            }
        }

        public static void RemoveUserProperty(MailItem mailitem)
        {
            UserProperties mailUserProperties = null;
            try
            {
                var pointer = 0;
                mailUserProperties = mailitem.UserProperties;
                for (var i = 1; i == mailUserProperties.Count; i++)
                {
                    if (mailUserProperties[i].Name == "KayakoTicketId") pointer = i;
                }
                mailUserProperties.Remove(pointer);
                mailitem.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (mailUserProperties != null) Marshal.ReleaseComObject(mailUserProperties);
            }
        }

        public static MailItem GetOutlookCurrentMailItem()
        {
            var activeExplorer = Globals.ThisAddIn.Application.ActiveExplorer();
            var selection = activeExplorer.Selection;
            MailItem mailItem = null;
            if (selection.Count > 0)
            {
                mailItem = (MailItem)selection[1];

                //var prop = mailItem.UserProperties.Find("KayakoTicketId");
                //if (prop != null)
                //{
                //    if (!string.IsNullOrEmpty(prop.Value))
                //    {
                //        if (_kayakoApiHelper.TicketExists(prop.Value) != null)
                //        {
                //            if (Message.Show("This email has already been created as a ticket, would you like to reset this email?",
                //                MessageType.Question) == DialogResult.Yes)
                //            {
                //                RemoveUserProperty(mailItem);
                //            }
                //            else if (Message.Show("This email has already been created as a ticket, would you like to open it in your browser?",
                //                    MessageType.Question) == DialogResult.Yes)
                //            {
                //                OpenTicketInBrowser(prop.Value);
                //            }
                //            return null;
                //        }
                //    }
                //}
            }
            return mailItem;
        }

        public static List<TicketAttachmentInfo> GetListOfSavedAttachments(MailItem mailItem)
        {
            if (mailItem == null) throw new ArgumentNullException("mailItem");

            var attachments = new List<TicketAttachmentInfo>();
            if (mailItem.Attachments.Count > 0)
            {
                foreach (Attachment attachment in mailItem.Attachments)
                {
                    //TODO: test met in-line pictues and logo's

                    //var SchemaPR_ATTACH_METHOD = @"http://schemas.microsoft.com/mapi/proptag/0x37050003";
                    //var SchemaPR_ATTACH_CONTENT_ID = @"http://schemas.microsoft.com/mapi/proptag/0x3712001E";

                    //var propertyAccessor = attachment.PropertyAccessor;
                    //var AttachMethod = propertyAccessor.GetProperty(SchemaPR_ATTACH_METHOD);
                    //var AttachCID = propertyAccessor.GetProperty(SchemaPR_ATTACH_CONTENT_ID);

                    //if (AttachCID == string.Empty)
                    //{
                    var path = string.Format("{0}\\{1}{2}{3}{4}", Environment.GetEnvironmentVariable("TEMP"),
                                             AssemblyInfo.Company, AssemblyInfo.Product, (Guid.NewGuid()),
                                             attachment.FileName);
                    attachment.SaveAsFile(path);
                    var ticketAttachmentInfo = new TicketAttachmentInfo
                    {
                        FileName = attachment.FileName,
                        TempFileName = path
                    };
                    attachments.Add(ticketAttachmentInfo);
                    //}
                }
            }
            return attachments;
        }

        public class TicketAttachmentInfo
        {
            public string TempFileName { get; set; }
            public string FileName { get; set; }
        }

    }
}
