// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The shared content request access type object</para>
    /// </summary>
    public class SharedContentRequestAccessType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentRequestAccessType> Encoder = new SharedContentRequestAccessTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentRequestAccessType> Decoder = new SharedContentRequestAccessTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedContentRequestAccessType"
        /// /> class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public SharedContentRequestAccessType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedContentRequestAccessType"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentRequestAccessType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the shared content request access type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentRequestAccessType" />.</para>
        /// </summary>
        private class SharedContentRequestAccessTypeEncoder : enc.StructEncoder<SharedContentRequestAccessType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentRequestAccessType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentRequestAccessType" />.</para>
        /// </summary>
        private class SharedContentRequestAccessTypeDecoder : enc.StructDecoder<SharedContentRequestAccessType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedContentRequestAccessType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentRequestAccessType Create()
            {
                return new SharedContentRequestAccessType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentRequestAccessType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
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
