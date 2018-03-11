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
    /// <para>Left the membership of a shared file or folder.</para>
    /// </summary>
    public class SharedContentRelinquishMembershipDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentRelinquishMembershipDetails> Encoder = new SharedContentRelinquishMembershipDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentRelinquishMembershipDetails> Decoder = new SharedContentRelinquishMembershipDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentRelinquishMembershipDetails" /> class.</para>
        /// </summary>
        /// <param name="targetAssetIndex">Target asset position in the Assets list.</param>
        /// <param name="originalFolderName">Original shared folder name.</param>
        public SharedContentRelinquishMembershipDetails(ulong targetAssetIndex,
                                                        string originalFolderName)
        {
            if (originalFolderName == null)
            {
                throw new sys.ArgumentNullException("originalFolderName");
            }

            this.TargetAssetIndex = targetAssetIndex;
            this.OriginalFolderName = originalFolderName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentRelinquishMembershipDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentRelinquishMembershipDetails()
        {
        }

        /// <summary>
        /// <para>Target asset position in the Assets list.</para>
        /// </summary>
        public ulong TargetAssetIndex { get; protected set; }

        /// <summary>
        /// <para>Original shared folder name.</para>
        /// </summary>
        public string OriginalFolderName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentRelinquishMembershipDetails" />.</para>
        /// </summary>
        private class SharedContentRelinquishMembershipDetailsEncoder : enc.StructEncoder<SharedContentRelinquishMembershipDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentRelinquishMembershipDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("target_asset_index", value.TargetAssetIndex, writer, enc.UInt64Encoder.Instance);
                WriteProperty("original_folder_name", value.OriginalFolderName, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentRelinquishMembershipDetails" />.</para>
        /// </summary>
        private class SharedContentRelinquishMembershipDetailsDecoder : enc.StructDecoder<SharedContentRelinquishMembershipDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharedContentRelinquishMembershipDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentRelinquishMembershipDetails Create()
            {
                return new SharedContentRelinquishMembershipDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentRelinquishMembershipDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "target_asset_index":
                        value.TargetAssetIndex = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    case "original_folder_name":
                        value.OriginalFolderName = enc.StringDecoder.Instance.Decode(reader);
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
