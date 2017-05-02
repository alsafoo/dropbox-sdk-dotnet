// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The transfer folder error object</para>
    /// </summary>
    public class TransferFolderError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TransferFolderError> Encoder = new TransferFolderErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TransferFolderError> Decoder = new TransferFolderErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TransferFolderError" />
        /// class.</para>
        /// </summary>
        public TransferFolderError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AccessError</para>
        /// </summary>
        public bool IsAccessError
        {
            get
            {
                return this is AccessError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AccessError, or <c>null</c>.</para>
        /// </summary>
        public AccessError AsAccessError
        {
            get
            {
                return this as AccessError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidDropboxId</para>
        /// </summary>
        public bool IsInvalidDropboxId
        {
            get
            {
                return this is InvalidDropboxId;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidDropboxId, or <c>null</c>.</para>
        /// </summary>
        public InvalidDropboxId AsInvalidDropboxId
        {
            get
            {
                return this as InvalidDropboxId;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NewOwnerNotAMember</para>
        /// </summary>
        public bool IsNewOwnerNotAMember
        {
            get
            {
                return this is NewOwnerNotAMember;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NewOwnerNotAMember, or <c>null</c>.</para>
        /// </summary>
        public NewOwnerNotAMember AsNewOwnerNotAMember
        {
            get
            {
                return this as NewOwnerNotAMember;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NewOwnerUnmounted</para>
        /// </summary>
        public bool IsNewOwnerUnmounted
        {
            get
            {
                return this is NewOwnerUnmounted;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NewOwnerUnmounted, or <c>null</c>.</para>
        /// </summary>
        public NewOwnerUnmounted AsNewOwnerUnmounted
        {
            get
            {
                return this as NewOwnerUnmounted;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// NewOwnerEmailUnverified</para>
        /// </summary>
        public bool IsNewOwnerEmailUnverified
        {
            get
            {
                return this is NewOwnerEmailUnverified;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NewOwnerEmailUnverified, or <c>null</c>.</para>
        /// </summary>
        public NewOwnerEmailUnverified AsNewOwnerEmailUnverified
        {
            get
            {
                return this as NewOwnerEmailUnverified;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TeamFolder</para>
        /// </summary>
        public bool IsTeamFolder
        {
            get
            {
                return this is TeamFolder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TeamFolder, or <c>null</c>.</para>
        /// </summary>
        public TeamFolder AsTeamFolder
        {
            get
            {
                return this as TeamFolder;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoPermission</para>
        /// </summary>
        public bool IsNoPermission
        {
            get
            {
                return this is NoPermission;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoPermission, or <c>null</c>.</para>
        /// </summary>
        public NoPermission AsNoPermission
        {
            get
            {
                return this as NoPermission;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TransferFolderError" />.</para>
        /// </summary>
        private class TransferFolderErrorEncoder : enc.StructEncoder<TransferFolderError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TransferFolderError value, enc.IJsonWriter writer)
            {
                if (value is AccessError)
                {
                    WriteProperty(".tag", "access_error", writer, enc.StringEncoder.Instance);
                    AccessError.Encoder.EncodeFields((AccessError)value, writer);
                    return;
                }
                if (value is InvalidDropboxId)
                {
                    WriteProperty(".tag", "invalid_dropbox_id", writer, enc.StringEncoder.Instance);
                    InvalidDropboxId.Encoder.EncodeFields((InvalidDropboxId)value, writer);
                    return;
                }
                if (value is NewOwnerNotAMember)
                {
                    WriteProperty(".tag", "new_owner_not_a_member", writer, enc.StringEncoder.Instance);
                    NewOwnerNotAMember.Encoder.EncodeFields((NewOwnerNotAMember)value, writer);
                    return;
                }
                if (value is NewOwnerUnmounted)
                {
                    WriteProperty(".tag", "new_owner_unmounted", writer, enc.StringEncoder.Instance);
                    NewOwnerUnmounted.Encoder.EncodeFields((NewOwnerUnmounted)value, writer);
                    return;
                }
                if (value is NewOwnerEmailUnverified)
                {
                    WriteProperty(".tag", "new_owner_email_unverified", writer, enc.StringEncoder.Instance);
                    NewOwnerEmailUnverified.Encoder.EncodeFields((NewOwnerEmailUnverified)value, writer);
                    return;
                }
                if (value is TeamFolder)
                {
                    WriteProperty(".tag", "team_folder", writer, enc.StringEncoder.Instance);
                    TeamFolder.Encoder.EncodeFields((TeamFolder)value, writer);
                    return;
                }
                if (value is NoPermission)
                {
                    WriteProperty(".tag", "no_permission", writer, enc.StringEncoder.Instance);
                    NoPermission.Encoder.EncodeFields((NoPermission)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TransferFolderError" />.</para>
        /// </summary>
        private class TransferFolderErrorDecoder : enc.UnionDecoder<TransferFolderError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TransferFolderError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TransferFolderError Create()
            {
                return new TransferFolderError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override TransferFolderError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "access_error":
                        return AccessError.Decoder.DecodeFields(reader);
                    case "invalid_dropbox_id":
                        return InvalidDropboxId.Decoder.DecodeFields(reader);
                    case "new_owner_not_a_member":
                        return NewOwnerNotAMember.Decoder.DecodeFields(reader);
                    case "new_owner_unmounted":
                        return NewOwnerUnmounted.Decoder.DecodeFields(reader);
                    case "new_owner_email_unverified":
                        return NewOwnerEmailUnverified.Decoder.DecodeFields(reader);
                    case "team_folder":
                        return TeamFolder.Decoder.DecodeFields(reader);
                    case "no_permission":
                        return NoPermission.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The access error object</para>
        /// </summary>
        public sealed class AccessError : TransferFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AccessError> Encoder = new AccessErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AccessError> Decoder = new AccessErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccessError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public AccessError(SharedFolderAccessError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccessError" />
            /// class.</para>
            /// </summary>
            private AccessError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public SharedFolderAccessError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AccessError" />.</para>
            /// </summary>
            private class AccessErrorEncoder : enc.StructEncoder<AccessError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AccessError value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.Sharing.SharedFolderAccessError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AccessError" />.</para>
            /// </summary>
            private class AccessErrorDecoder : enc.StructDecoder<AccessError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AccessError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AccessError Create()
                {
                    return new AccessError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(AccessError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "access_error":
                            value.Value = global::Dropbox.Api.Sharing.SharedFolderAccessError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para><see cref="Dropbox.Api.Sharing.TransferFolderArg.ToDropboxId" /> is
        /// invalid.</para>
        /// </summary>
        public sealed class InvalidDropboxId : TransferFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidDropboxId> Encoder = new InvalidDropboxIdEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidDropboxId> Decoder = new InvalidDropboxIdDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidDropboxId" />
            /// class.</para>
            /// </summary>
            private InvalidDropboxId()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidDropboxId</para>
            /// </summary>
            public static readonly InvalidDropboxId Instance = new InvalidDropboxId();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidDropboxId" />.</para>
            /// </summary>
            private class InvalidDropboxIdEncoder : enc.StructEncoder<InvalidDropboxId>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidDropboxId value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidDropboxId" />.</para>
            /// </summary>
            private class InvalidDropboxIdDecoder : enc.StructDecoder<InvalidDropboxId>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidDropboxId" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidDropboxId Create()
                {
                    return InvalidDropboxId.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The new designated owner is not currently a member of the shared
        /// folder.</para>
        /// </summary>
        public sealed class NewOwnerNotAMember : TransferFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NewOwnerNotAMember> Encoder = new NewOwnerNotAMemberEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NewOwnerNotAMember> Decoder = new NewOwnerNotAMemberDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NewOwnerNotAMember" />
            /// class.</para>
            /// </summary>
            private NewOwnerNotAMember()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NewOwnerNotAMember</para>
            /// </summary>
            public static readonly NewOwnerNotAMember Instance = new NewOwnerNotAMember();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NewOwnerNotAMember" />.</para>
            /// </summary>
            private class NewOwnerNotAMemberEncoder : enc.StructEncoder<NewOwnerNotAMember>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NewOwnerNotAMember value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NewOwnerNotAMember" />.</para>
            /// </summary>
            private class NewOwnerNotAMemberDecoder : enc.StructDecoder<NewOwnerNotAMember>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NewOwnerNotAMember"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NewOwnerNotAMember Create()
                {
                    return NewOwnerNotAMember.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The new designated owner has not added the folder to their Dropbox.</para>
        /// </summary>
        public sealed class NewOwnerUnmounted : TransferFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NewOwnerUnmounted> Encoder = new NewOwnerUnmountedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NewOwnerUnmounted> Decoder = new NewOwnerUnmountedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NewOwnerUnmounted" />
            /// class.</para>
            /// </summary>
            private NewOwnerUnmounted()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NewOwnerUnmounted</para>
            /// </summary>
            public static readonly NewOwnerUnmounted Instance = new NewOwnerUnmounted();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NewOwnerUnmounted" />.</para>
            /// </summary>
            private class NewOwnerUnmountedEncoder : enc.StructEncoder<NewOwnerUnmounted>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NewOwnerUnmounted value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NewOwnerUnmounted" />.</para>
            /// </summary>
            private class NewOwnerUnmountedDecoder : enc.StructDecoder<NewOwnerUnmounted>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NewOwnerUnmounted"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NewOwnerUnmounted Create()
                {
                    return NewOwnerUnmounted.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The new designated owner's e-mail address is unverified.</para>
        /// </summary>
        public sealed class NewOwnerEmailUnverified : TransferFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NewOwnerEmailUnverified> Encoder = new NewOwnerEmailUnverifiedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NewOwnerEmailUnverified> Decoder = new NewOwnerEmailUnverifiedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NewOwnerEmailUnverified" />
            /// class.</para>
            /// </summary>
            private NewOwnerEmailUnverified()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NewOwnerEmailUnverified</para>
            /// </summary>
            public static readonly NewOwnerEmailUnverified Instance = new NewOwnerEmailUnverified();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NewOwnerEmailUnverified" />.</para>
            /// </summary>
            private class NewOwnerEmailUnverifiedEncoder : enc.StructEncoder<NewOwnerEmailUnverified>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NewOwnerEmailUnverified value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NewOwnerEmailUnverified" />.</para>
            /// </summary>
            private class NewOwnerEmailUnverifiedDecoder : enc.StructDecoder<NewOwnerEmailUnverified>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NewOwnerEmailUnverified"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NewOwnerEmailUnverified Create()
                {
                    return NewOwnerEmailUnverified.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>This action cannot be performed on a team shared folder.</para>
        /// </summary>
        public sealed class TeamFolder : TransferFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TeamFolder> Encoder = new TeamFolderEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TeamFolder> Decoder = new TeamFolderDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TeamFolder" /> class.</para>
            /// </summary>
            private TeamFolder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TeamFolder</para>
            /// </summary>
            public static readonly TeamFolder Instance = new TeamFolder();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TeamFolder" />.</para>
            /// </summary>
            private class TeamFolderEncoder : enc.StructEncoder<TeamFolder>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TeamFolder value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TeamFolder" />.</para>
            /// </summary>
            private class TeamFolderDecoder : enc.StructDecoder<TeamFolder>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TeamFolder" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TeamFolder Create()
                {
                    return TeamFolder.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The current user does not have permission to perform this action.</para>
        /// </summary>
        public sealed class NoPermission : TransferFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NoPermission> Encoder = new NoPermissionEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NoPermission> Decoder = new NoPermissionDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoPermission" />
            /// class.</para>
            /// </summary>
            private NoPermission()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NoPermission</para>
            /// </summary>
            public static readonly NoPermission Instance = new NoPermission();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionEncoder : enc.StructEncoder<NoPermission>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NoPermission value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionDecoder : enc.StructDecoder<NoPermission>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NoPermission" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NoPermission Create()
                {
                    return NoPermission.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : TransferFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
