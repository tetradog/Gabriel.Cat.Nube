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
    /// <para>Changed whether members can see who viewed the shared file or folder.</para>
    /// </summary>
    public class SharedContentChangeViewerInfoPolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentChangeViewerInfoPolicyDetails> Encoder = new SharedContentChangeViewerInfoPolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentChangeViewerInfoPolicyDetails> Decoder = new SharedContentChangeViewerInfoPolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentChangeViewerInfoPolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="targetAssetIndex">Target asset position in the Assets list.</param>
        /// <param name="newValue">New viewer info policy.</param>
        /// <param name="originalFolderName">Original shared folder name.</param>
        /// <param name="sharedFolderType">Shared folder type. Might be missing due to
        /// historical data gap.</param>
        /// <param name="previousValue">Previous view info policy. Might be missing due to
        /// historical data gap.</param>
        public SharedContentChangeViewerInfoPolicyDetails(ulong targetAssetIndex,
                                                          SharedContentViewerInfoPolicy newValue,
                                                          string originalFolderName = null,
                                                          string sharedFolderType = null,
                                                          SharedContentViewerInfoPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.TargetAssetIndex = targetAssetIndex;
            this.NewValue = newValue;
            this.OriginalFolderName = originalFolderName;
            this.SharedFolderType = sharedFolderType;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentChangeViewerInfoPolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentChangeViewerInfoPolicyDetails()
        {
        }

        /// <summary>
        /// <para>Target asset position in the Assets list.</para>
        /// </summary>
        public ulong TargetAssetIndex { get; protected set; }

        /// <summary>
        /// <para>New viewer info policy.</para>
        /// </summary>
        public SharedContentViewerInfoPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Original shared folder name.</para>
        /// </summary>
        public string OriginalFolderName { get; protected set; }

        /// <summary>
        /// <para>Shared folder type. Might be missing due to historical data gap.</para>
        /// </summary>
        public string SharedFolderType { get; protected set; }

        /// <summary>
        /// <para>Previous view info policy. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public SharedContentViewerInfoPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentChangeViewerInfoPolicyDetails"
        /// />.</para>
        /// </summary>
        private class SharedContentChangeViewerInfoPolicyDetailsEncoder : enc.StructEncoder<SharedContentChangeViewerInfoPolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentChangeViewerInfoPolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("target_asset_index", value.TargetAssetIndex, writer, enc.UInt64Encoder.Instance);
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.SharedContentViewerInfoPolicy.Encoder);
                if (value.OriginalFolderName != null)
                {
                    WriteProperty("original_folder_name", value.OriginalFolderName, writer, enc.StringEncoder.Instance);
                }
                if (value.SharedFolderType != null)
                {
                    WriteProperty("shared_folder_type", value.SharedFolderType, writer, enc.StringEncoder.Instance);
                }
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.SharedContentViewerInfoPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentChangeViewerInfoPolicyDetails"
        /// />.</para>
        /// </summary>
        private class SharedContentChangeViewerInfoPolicyDetailsDecoder : enc.StructDecoder<SharedContentChangeViewerInfoPolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharedContentChangeViewerInfoPolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentChangeViewerInfoPolicyDetails Create()
            {
                return new SharedContentChangeViewerInfoPolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentChangeViewerInfoPolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "target_asset_index":
                        value.TargetAssetIndex = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.SharedContentViewerInfoPolicy.Decoder.Decode(reader);
                        break;
                    case "original_folder_name":
                        value.OriginalFolderName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "shared_folder_type":
                        value.SharedFolderType = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.SharedContentViewerInfoPolicy.Decoder.Decode(reader);
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
