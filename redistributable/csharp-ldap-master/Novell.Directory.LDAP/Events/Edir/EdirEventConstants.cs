/******************************************************************************
* The MIT License
* Copyright (c) 2003 Novell Inc.  www.novell.com
* 
* Permission is hereby granted, free of charge, to any person obtaining  a copy
* of this software and associated documentation files (the Software), to deal
* in the Software without restriction, including  without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
* copies of the Software, and to  permit persons to whom the Software is 
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in 
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED AS IS, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*******************************************************************************/
//
// Novell.Directory.Ldap.Events.Edir.EdirEventConstants.cs
//
// Author:
//   Anil Bhatia (banil@novell.com)
//
// (C) 2003 Novell, Inc (http://www.novell.com)
//

namespace Novell.Directory.Ldap.Events.Edir
{
    /// <summary>
    ///     Enumeration for types of Edir event data
    /// </summary>
    public enum EdirEventDataType
    {
        EDIR_TAG_ENTRY_EVENT_DATA = 1,
        EDIR_TAG_VALUE_EVENT_DATA,
        EDIR_TAG_GENERAL_EVENT_DATA,
        EDIR_TAG_SKULK_DATA,
        EDIR_TAG_BINDERY_EVENT_DATA,
        EDIR_TAG_DSESEV_INFO,
        EDIR_TAG_MODULE_STATE_DATA,
        EDIR_TAG_NETWORK_ADDRESS,
        EDIR_TAG_CONNECTION_STATE,
        EDIR_TAG_CHANGE_SERVER_ADDRESS,
        EDIR_TAG_CHANGE_CONFIG_PARAM,
        EDIR_TAG_NO_DATA,
        EDIR_TAG_STATUS_LOG,
        EDIR_TAG_DEBUG_EVENT_DATA
    }

    /// <summary>
    ///     Enumeration for types of Edir event results
    /// </summary>
    public enum EdirEventResultType
    {
        EVT_STATUS_ALL,
        EVT_STATUS_SUCCESS,
        EVT_STATUS_FAILURE
    }

    /// <summary>
    ///     Enumeration for types of Edir events
    /// </summary>
    public enum EdirEventType
    {
        EVT_INVALID = 0,
        EVT_CREATE_ENTRY = 1,
        EVT_DELETE_ENTRY = 2,
        EVT_RENAME_ENTRY = 3,
        EVT_MOVE_SOURCE_ENTRY = 4,
        EVT_ADD_VALUE = 5,
        EVT_DELETE_VALUE = 6,
        EVT_CLOSE_STREAM = 7,
        EVT_DELETE_ATTRIBUTE = 8,
        EVT_SET_BINDERY_CONTEXT = 9,
        EVT_CREATE_BINDERY_OBJECT = 10,
        EVT_DELETE_BINDERY_OBJECT = 11,
        EVT_CHECK_SEV = 12,
        EVT_UPDATE_SEV = 13,
        EVT_MOVE_DEST_ENTRY = 14,
        EVT_DELETE_UNUSED_EXTREF = 15,
        EVT_REMOTE_SERVER_DOWN = 17,
        EVT_NCP_RETRY_EXPENDED = 18,
        EVT_PARTITION_OPERATION_EVENT = 20,
        EVT_CHANGE_MODULE_STATE = 21,
        EVT_DB_AUTHEN = 26,
        EVT_DB_BACKLINK = 27,
        EVT_DB_BUFFERS = 28,
        EVT_DB_COLL = 29,
        EVT_DB_DSAGENT = 30,
        EVT_DB_EMU = 31,
        EVT_DB_FRAGGER = 32,
        EVT_DB_INIT = 33,
        EVT_DB_INSPECTOR = 34,
        EVT_DB_JANITOR = 35,
        EVT_DB_LIMBER = 36,
        EVT_DB_LOCKING = 37,
        EVT_DB_MOVE = 38,
        EVT_DB_MIN = 39,
        EVT_DB_MISC = 40,
        EVT_DB_PART = 41,
        EVT_DB_RECMAN = 42,
        EVT_DB_RESNAME = 44,
        EVT_DB_SAP = 45,
        EVT_DB_SCHEMA = 46,
        EVT_DB_SKULKER = 47,
        EVT_DB_STREAMS = 48,
        EVT_DB_SYNC_IN = 49,
        EVT_DB_THREADS = 50,
        EVT_DB_TIMEVECTOR = 51,
        EVT_DB_VCLIENT = 52,
        EVT_AGENT_OPEN_LOCAL = 53,
        EVT_AGENT_CLOSE_LOCAL = 54,
        EVT_DS_ERR_VIA_BINDERY = 55,
        EVT_DSA_BAD_VERB = 56,
        EVT_DSA_REQUEST_START = 57,
        EVT_DSA_REQUEST_END = 58,
        EVT_MOVE_SUBTREE = 59,
        EVT_NO_REPLICA_PTR = 60,
        EVT_SYNC_IN_END = 61,
        EVT_BKLINK_SEV = 62,
        EVT_BKLINK_OPERATOR = 63,
        EVT_DELETE_SUBTREE = 64,
        EVT_REFERRAL = 67,
        EVT_UPDATE_CLASS_DEF = 68,
        EVT_UPDATE_ATTR_DEF = 69,
        EVT_LOST_ENTRY = 70,
        EVT_PURGE_ENTRY_FAIL = 71,
        EVT_PURGE_START = 72,
        EVT_PURGE_END = 73,
        EVT_LIMBER_DONE = 76,
        EVT_SPLIT_DONE = 77,
        EVT_SYNC_SVR_OUT_START = 78,
        EVT_SYNC_SVR_OUT_END = 79,
        EVT_SYNC_PART_START = 80,
        EVT_SYNC_PART_END = 81,
        EVT_MOVE_TREE_START = 82,
        EVT_MOVE_TREE_END = 83,
        EVT_JOIN_DONE = 86,
        EVT_PARTITION_LOCKED = 87,
        EVT_PARTITION_UNLOCKED = 88,
        EVT_SCHEMA_SYNC = 89,
        EVT_NAME_COLLISION = 90,
        EVT_NLM_LOADED = 91,
        EVT_LUMBER_DONE = 94,
        EVT_BACKLINK_PROC_DONE = 95,
        EVT_SERVER_RENAME = 96,
        EVT_SYNTHETIC_TIME = 97,
        EVT_SERVER_ADDRESS_CHANGE = 98,
        EVT_DSA_READ = 99,
        EVT_LOGIN = 100,
        EVT_CHGPASS = 101,
        EVT_LOGOUT = 102,
        EVT_ADD_REPLICA = 103,
        EVT_REMOVE_REPLICA = 104,
        EVT_SPLIT_PARTITION = 105,
        EVT_JOIN_PARTITIONS = 106,
        EVT_CHANGE_REPLICA_TYPE = 107,
        EVT_REMOVE_ENTRY = 108,
        EVT_ABORT_PARTITION_OP = 109,
        EVT_RECV_REPLICA_UPDATES = 110,
        EVT_REPAIR_TIME_STAMPS = 111,
        EVT_SEND_REPLICA_UPDATES = 112,
        EVT_VERIFY_PASS = 113,
        EVT_BACKUP_ENTRY = 114,
        EVT_RESTORE_ENTRY = 115,
        EVT_DEFINE_ATTR_DEF = 116,
        EVT_REMOVE_ATTR_DEF = 117,
        EVT_REMOVE_CLASS_DEF = 118,
        EVT_DEFINE_CLASS_DEF = 119,
        EVT_MODIFY_CLASS_DEF = 120,
        EVT_RESET_DS_COUNTERS = 121,
        EVT_REMOVE_ENTRY_DIR = 122,
        EVT_COMPARE_ATTR_VALUE = 123,
        EVT_STREAM = 124,
        EVT_LIST_SUBORDINATES = 125,
        EVT_LIST_CONT_CLASSES = 126,
        EVT_INSPECT_ENTRY = 127,
        EVT_RESEND_ENTRY = 128,
        EVT_MUTATE_ENTRY = 129,
        EVT_MERGE_ENTRIES = 130,
        EVT_MERGE_TREE = 131,
        EVT_CREATE_SUBREF = 132,
        EVT_LIST_PARTITIONS = 133,
        EVT_READ_ATTR = 134,
        EVT_READ_REFERENCES = 135,
        EVT_UPDATE_REPLICA = 136,
        EVT_START_UPDATE_REPLICA = 137,
        EVT_END_UPDATE_REPLICA = 138,
        EVT_SYNC_PARTITION = 139,
        EVT_SYNC_SCHEMA = 140,
        EVT_CREATE_BACKLINK = 141,
        EVT_CHECK_CONSOLE_OPERATOR = 142,
        EVT_CHANGE_TREE_NAME = 143,
        EVT_START_JOIN = 144,
        EVT_ABORT_JOIN = 145,
        EVT_UPDATE_SCHEMA = 146,
        EVT_START_UPDATE_SCHEMA = 147,
        EVT_END_UPDATE_SCHEMA = 148,
        EVT_MOVE_TREE = 149,
        EVT_RELOAD_DS = 150,
        EVT_ADD_PROPERTY = 151,
        EVT_DELETE_PROPERTY = 152,
        EVT_ADD_MEMBER = 153,
        EVT_DELETE_MEMBER = 154,
        EVT_CHANGE_PROP_SECURITY = 155,
        EVT_CHANGE_OBJ_SECURITY = 156,
        EVT_CONNECT_TO_ADDRESS = 158,
        EVT_SEARCH = 159,
        EVT_PARTITION_STATE_CHG = 160,
        EVT_REMOVE_BACKLINK = 161,
        EVT_LOW_LEVEL_JOIN = 162,
        EVT_CREATE_NAMEBASE = 163,
        EVT_CHANGE_SECURITY_EQUALS = 164,
        EVT_DB_NCPENG = 166,
        EVT_CRC_FAILURE = 167,
        EVT_ADD_ENTRY = 168,
        EVT_MODIFY_ENTRY = 169,
        EVT_OPEN_BINDERY = 171,
        EVT_CLOSE_BINDERY = 172,
        EVT_CHANGE_CONN_STATE = 173,
        EVT_NEW_SCHEMA_EPOCH = 174,
        EVT_DB_AUDIT = 175,
        EVT_DB_AUDIT_NCP = 176,
        EVT_DB_AUDIT_SKULK = 177,
        EVT_MODIFY_RDN = 178,
        EVT_ENTRYID_SWAP = 181,
        EVT_INSIDE_NCP_REQUEST = 182,
        EVT_DB_LOST_ENTRY = 183,
        EVT_DB_CHANGE_CACHE = 184,
        EVT_LOW_LEVEL_SPLIT = 185,
        EVT_DB_PURGE = 186,
        EVT_END_NAMEBASE_TRANSACTION = 187,
        EVT_ALLOW_LOGIN = 188,
        EVT_DB_CLIENT_BUFFERS = 189,
        EVT_DB_WANMAN = 190,
        EVT_LOCAL_REPLICA_CHANGE = 197,
        EVT_DB_DRL = 198,
        EVT_MOVE_ENTRY_SOURCE = 199,
        EVT_MOVE_ENTRY_DEST = 200,
        EVT_NOTIFY_REF_CHANGE = 201,
        EVT_DB_ALLOC = 202,
        EVT_CONSOLE_OPERATION = 203,
        EVT_DB_SERVER_PACKET = 204,
        EVT_DB_OBIT = 207,
        EVT_REPLICA_IN_TRANSITION = 208,
        EVT_DB_SYNC_DETAIL = 209,
        EVT_DB_CONN_TRACE = 210,
        /*
        EVT_CHANGE_CONFIG_PARM = 211,
        EVT_COMPUTE_CONN_SEV_INLINE = 212,
        */
        EVT_BEGIN_NAMEBASE_TRANSACTION = 213,
        EVT_DB_DIRXML = 214,
        EVT_VR_DRIVER_STATE_CHANGE = 215,
        EVT_REQ_UPDATE_SERVER_STATUS = 216,
        EVT_DB_DIRXML_DRIVERS = 217,
        EVT_DB_NDSMON = 218,
        EVT_CHANGE_SERVER_ADDRS = 219,
        EVT_DB_DNS = 220,
        EVT_DB_REPAIR = 221,
        EVT_DB_REPAIR_DEBUG = 222,
        EVT_ITERATOR = 224,
        EVT_DB_SCHEMA_DETAIL = 225,
        EVT_LOW_LEVEL_JOIN_BEGIN = 226,
        EVT_DB_IN_SYNC_DETAIL = 227,
        EVT_PRE_DELETE_ENTRY = 228,
        EVT_DB_SSL = 229,
        EVT_DB_PKI = 230,
        EVT_DB_HTTPSTK = 231,
        EVT_DB_LDAPSTK = 232,
        EVT_DB_NICIEXT = 233,
        EVT_DB_SECRET_STORE = 234,
        EVT_DB_NMAS = 235,
        EVT_DB_BACKLINK_DETAIL = 236,
        EVT_DB_DRL_DETAIL = 237,
        EVT_DB_OBJECT_PRODUCER = 238,
        EVT_DB_SEARCH = 239,
        EVT_DB_SEARCH_DETAIL = 240,
        EVT_STATUS_LOG = 241,
        EVT_DB_NPKI_API = 242,
        EVT_MAX_EVENTS
    }

    /// <summary>
    ///     Enumeration for types of Edir event Debug parameters
    /// </summary>
    public enum DebugParameterType
    {
        ENTRYID = 1,
        STRING,
        BINARY,
        INTEGER,
        ADDRESS,
        TIMESTAMP,
        TIMEVECTOR
    }

    /// <summary>
    ///     Enumeration for fields of Edir General event
    /// </summary>
    public enum GeneralEventField
    {
        EVT_TAG_GEN_DSTIME = 1,
        EVT_TAG_GEN_MILLISEC,
        EVT_TAG_GEN_VERB,
        EVT_TAG_GEN_CURRPROC,
        EVT_TAG_GEN_PERP,
        EVT_TAG_GEN_INTEGERS,
        EVT_TAG_GEN_STRINGS
    }

    public class EventOids
    {
        /* Oid for requests */

        public const string NLDAP_MONITOR_EVENTS_REQUEST =
            "2.16.840.1.113719.1.27.100.79";

        public const string NLDAP_MONITOR_EVENTS_RESPONSE =
            "2.16.840.1.113719.1.27.100.80";

        public const string NLDAP_EVENT_NOTIFICATION =
            "2.16.840.1.113719.1.27.100.81";

        public const string NLDAP_FILTERED_MONITOR_EVENTS_REQUEST =
            "2.16.840.1.113719.1.27.100.84";
    }
}