/*
 *
 * (c) Copyright Ascensio System Limited 2010-2020
 *
 * This program is freeware. You can redistribute it and/or modify it under the terms of the GNU 
 * General Public License (GPL) version 3 as published by the Free Software Foundation (https://www.gnu.org/copyleft/gpl.html). 
 * In accordance with Section 7(a) of the GNU GPL its Section 15 shall be amended to the effect that 
 * Ascensio System SIA expressly excludes the warranty of non-infringement of any third-party rights.
 *
 * THIS PROGRAM IS DISTRIBUTED WITHOUT ANY WARRANTY; WITHOUT EVEN THE IMPLIED WARRANTY OF MERCHANTABILITY OR
 * FITNESS FOR A PARTICULAR PURPOSE. For more details, see GNU GPL at https://www.gnu.org/copyleft/gpl.html
 *
 * You can contact Ascensio System SIA by email at sales@onlyoffice.com
 *
 * The interactive user interfaces in modified source and object code versions of ONLYOFFICE must display 
 * Appropriate Legal Notices, as required under Section 5 of the GNU GPL version 3.
 *
 * Pursuant to Section 7 § 3(b) of the GNU GPL you must retain the original ONLYOFFICE logo which contains 
 * relevant author attributions when distributing the software. If the display of the logo in its graphic 
 * form is not reasonably feasible for technical reasons, you must include the words "Powered by ONLYOFFICE" 
 * in every copy of the program you distribute. 
 * Pursuant to Section 7 § 3(e) we decline to grant you any rights under trademark law for use of our trademarks.
 *
*/


// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using ASC.Mail.Core.DbSchema.Interfaces;

namespace ASC.Mail.Core.DbSchema.Tables
{
    public class UserFolderTable : ITable
    {
        public const string TABLE_NAME = "mail_user_folder";

        public static class Columns
        {
            public const string Id = "id";
            public const string ParentId = "parent_id";
            
            public const string Tenant = "tenant";
            public const string User = "id_user";

            public const string Name = "name";
            public const string FolderCount = "folders_count";

            public const string UnreadMessagesCount = "unread_messages_count";
            public const string TotalMessagesCount = "total_messages_count";

            public const string UnreadConversationsCount = "unread_conversations_count";
            public const string TotalConversationsCount = "total_conversations_count";

            public const string TimeModified = "modified_on";
        }

        public string Name
        {
            get { return TABLE_NAME; }
        }

        public IEnumerable<string> OrderedColumnCollection { get; private set; }

        public UserFolderTable()
        {
            OrderedColumnCollection = new List<string>
            {
                Columns.Id,
                Columns.ParentId,
                Columns.Tenant,
                Columns.User,
                Columns.Name,
                Columns.FolderCount,
                Columns.UnreadMessagesCount,
                Columns.TotalMessagesCount,
                Columns.UnreadConversationsCount,
                Columns.TotalConversationsCount,
                Columns.TimeModified
            };
        }
    }
}