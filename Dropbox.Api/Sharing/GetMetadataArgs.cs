// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The get metadata args object</para>
    /// </summary>
    public class GetMetadataArgs
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetMetadataArgs> Encoder = new GetMetadataArgsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetMetadataArgs> Decoder = new GetMetadataArgsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetMetadataArgs" />
        /// class.</para>
        /// </summary>
        /// <param name="sharedFolderId">The ID for the shared folder.</param>
        /// <param name="actions">Folder actions to query.</param>
        public GetMetadataArgs(string sharedFolderId,
                               col.IEnumerable<FolderAction> actions = null)
        {
            if (sharedFolderId == null)
            {
                throw new sys.ArgumentNullException("sharedFolderId");
            }
            else if (!re.Regex.IsMatch(sharedFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("sharedFolderId");
            }

            var actionsList = enc.Util.ToList(actions);

            this.SharedFolderId = sharedFolderId;
            this.Actions = actionsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetMetadataArgs" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GetMetadataArgs()
        {
        }

        /// <summary>
        /// <para>The ID for the shared folder.</para>
        /// </summary>
        public string SharedFolderId { get; protected set; }

        /// <summary>
        /// <para>Folder actions to query.</para>
        /// </summary>
        public col.IList<FolderAction> Actions { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetMetadataArgs" />.</para>
        /// </summary>
        private class GetMetadataArgsEncoder : enc.StructEncoder<GetMetadataArgs>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetMetadataArgs value, enc.IJsonWriter writer)
            {
                WriteProperty("shared_folder_id", value.SharedFolderId, writer, enc.StringEncoder.Instance);
                if (value.Actions.Count > 0)
                {
                    WriteListProperty("actions", value.Actions, writer, Dropbox.Api.Sharing.FolderAction.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetMetadataArgs" />.</para>
        /// </summary>
        private class GetMetadataArgsDecoder : enc.StructDecoder<GetMetadataArgs>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetMetadataArgs" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetMetadataArgs Create()
            {
                return new GetMetadataArgs();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GetMetadataArgs value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "shared_folder_id":
                        value.SharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "actions":
                        value.Actions = ReadList<FolderAction>(reader, Dropbox.Api.Sharing.FolderAction.Decoder);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}