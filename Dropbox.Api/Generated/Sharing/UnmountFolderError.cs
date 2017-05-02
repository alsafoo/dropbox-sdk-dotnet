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
    /// <para>The unmount folder error object</para>
    /// </summary>
    public class UnmountFolderError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UnmountFolderError> Encoder = new UnmountFolderErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UnmountFolderError> Decoder = new UnmountFolderErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UnmountFolderError" />
        /// class.</para>
        /// </summary>
        public UnmountFolderError()
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
        /// <para>Gets a value indicating whether this instance is NotUnmountable</para>
        /// </summary>
        public bool IsNotUnmountable
        {
            get
            {
                return this is NotUnmountable;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotUnmountable, or <c>null</c>.</para>
        /// </summary>
        public NotUnmountable AsNotUnmountable
        {
            get
            {
                return this as NotUnmountable;
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
        /// <para>Encoder for  <see cref="UnmountFolderError" />.</para>
        /// </summary>
        private class UnmountFolderErrorEncoder : enc.StructEncoder<UnmountFolderError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UnmountFolderError value, enc.IJsonWriter writer)
            {
                if (value is AccessError)
                {
                    WriteProperty(".tag", "access_error", writer, enc.StringEncoder.Instance);
                    AccessError.Encoder.EncodeFields((AccessError)value, writer);
                    return;
                }
                if (value is NoPermission)
                {
                    WriteProperty(".tag", "no_permission", writer, enc.StringEncoder.Instance);
                    NoPermission.Encoder.EncodeFields((NoPermission)value, writer);
                    return;
                }
                if (value is NotUnmountable)
                {
                    WriteProperty(".tag", "not_unmountable", writer, enc.StringEncoder.Instance);
                    NotUnmountable.Encoder.EncodeFields((NotUnmountable)value, writer);
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
        /// <para>Decoder for  <see cref="UnmountFolderError" />.</para>
        /// </summary>
        private class UnmountFolderErrorDecoder : enc.UnionDecoder<UnmountFolderError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UnmountFolderError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UnmountFolderError Create()
            {
                return new UnmountFolderError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override UnmountFolderError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "access_error":
                        return AccessError.Decoder.DecodeFields(reader);
                    case "no_permission":
                        return NoPermission.Decoder.DecodeFields(reader);
                    case "not_unmountable":
                        return NotUnmountable.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The access error object</para>
        /// </summary>
        public sealed class AccessError : UnmountFolderError
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
        /// <para>The current user does not have permission to perform this action.</para>
        /// </summary>
        public sealed class NoPermission : UnmountFolderError
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
        /// <para>The shared folder can't be unmounted. One example where this can occur is
        /// when the shared folder's parent folder is also a shared folder that resides in the
        /// current user's Dropbox.</para>
        /// </summary>
        public sealed class NotUnmountable : UnmountFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotUnmountable> Encoder = new NotUnmountableEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotUnmountable> Decoder = new NotUnmountableDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotUnmountable" />
            /// class.</para>
            /// </summary>
            private NotUnmountable()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotUnmountable</para>
            /// </summary>
            public static readonly NotUnmountable Instance = new NotUnmountable();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotUnmountable" />.</para>
            /// </summary>
            private class NotUnmountableEncoder : enc.StructEncoder<NotUnmountable>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotUnmountable value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotUnmountable" />.</para>
            /// </summary>
            private class NotUnmountableDecoder : enc.StructDecoder<NotUnmountable>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotUnmountable" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotUnmountable Create()
                {
                    return NotUnmountable.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : UnmountFolderError
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
