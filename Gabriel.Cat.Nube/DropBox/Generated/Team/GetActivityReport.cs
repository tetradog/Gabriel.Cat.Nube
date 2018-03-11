// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Activity Report Result. Each of the items in the storage report is an array of
    /// values, one value per day. If there is no data for a day, then the value will be
    /// None.</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Team.BaseDfbReport" />
    public class GetActivityReport : BaseDfbReport
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetActivityReport> Encoder = new GetActivityReportEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetActivityReport> Decoder = new GetActivityReportDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetActivityReport" />
        /// class.</para>
        /// </summary>
        /// <param name="startDate">First date present in the results as 'YYYY-MM-DD' or
        /// None.</param>
        /// <param name="adds">Array of total number of adds by team members.</param>
        /// <param name="edits">Array of number of edits by team members. If the same user
        /// edits the same file multiple times this is counted as a single edit.</param>
        /// <param name="deletes">Array of total number of deletes by team members.</param>
        /// <param name="activeUsers28Day">Array of the number of users who have been active in
        /// the last 28 days.</param>
        /// <param name="activeUsers7Day">Array of the number of users who have been active in
        /// the last week.</param>
        /// <param name="activeUsers1Day">Array of the number of users who have been active in
        /// the last day.</param>
        /// <param name="activeSharedFolders28Day">Array of the number of shared folders with
        /// some activity in the last 28 days.</param>
        /// <param name="activeSharedFolders7Day">Array of the number of shared folders with
        /// some activity in the last week.</param>
        /// <param name="activeSharedFolders1Day">Array of the number of shared folders with
        /// some activity in the last day.</param>
        /// <param name="sharedLinksCreated">Array of the number of shared links
        /// created.</param>
        /// <param name="sharedLinksViewedByTeam">Array of the number of views by team users to
        /// shared links created by the team.</param>
        /// <param name="sharedLinksViewedByOutsideUser">Array of the number of views by users
        /// outside of the team to shared links created by the team.</param>
        /// <param name="sharedLinksViewedByNotLoggedIn">Array of the number of views by
        /// non-logged-in users to shared links created by the team.</param>
        /// <param name="sharedLinksViewedTotal">Array of the total number of views to shared
        /// links created by the team.</param>
        public GetActivityReport(string startDate,
                                 col.IEnumerable<ulong?> adds,
                                 col.IEnumerable<ulong?> edits,
                                 col.IEnumerable<ulong?> deletes,
                                 col.IEnumerable<ulong?> activeUsers28Day,
                                 col.IEnumerable<ulong?> activeUsers7Day,
                                 col.IEnumerable<ulong?> activeUsers1Day,
                                 col.IEnumerable<ulong?> activeSharedFolders28Day,
                                 col.IEnumerable<ulong?> activeSharedFolders7Day,
                                 col.IEnumerable<ulong?> activeSharedFolders1Day,
                                 col.IEnumerable<ulong?> sharedLinksCreated,
                                 col.IEnumerable<ulong?> sharedLinksViewedByTeam,
                                 col.IEnumerable<ulong?> sharedLinksViewedByOutsideUser,
                                 col.IEnumerable<ulong?> sharedLinksViewedByNotLoggedIn,
                                 col.IEnumerable<ulong?> sharedLinksViewedTotal)
            : base(startDate)
        {
            var addsList = enc.Util.ToList(adds);

            if (adds == null)
            {
                throw new sys.ArgumentNullException("adds");
            }

            var editsList = enc.Util.ToList(edits);

            if (edits == null)
            {
                throw new sys.ArgumentNullException("edits");
            }

            var deletesList = enc.Util.ToList(deletes);

            if (deletes == null)
            {
                throw new sys.ArgumentNullException("deletes");
            }

            var activeUsers28DayList = enc.Util.ToList(activeUsers28Day);

            if (activeUsers28Day == null)
            {
                throw new sys.ArgumentNullException("activeUsers28Day");
            }

            var activeUsers7DayList = enc.Util.ToList(activeUsers7Day);

            if (activeUsers7Day == null)
            {
                throw new sys.ArgumentNullException("activeUsers7Day");
            }

            var activeUsers1DayList = enc.Util.ToList(activeUsers1Day);

            if (activeUsers1Day == null)
            {
                throw new sys.ArgumentNullException("activeUsers1Day");
            }

            var activeSharedFolders28DayList = enc.Util.ToList(activeSharedFolders28Day);

            if (activeSharedFolders28Day == null)
            {
                throw new sys.ArgumentNullException("activeSharedFolders28Day");
            }

            var activeSharedFolders7DayList = enc.Util.ToList(activeSharedFolders7Day);

            if (activeSharedFolders7Day == null)
            {
                throw new sys.ArgumentNullException("activeSharedFolders7Day");
            }

            var activeSharedFolders1DayList = enc.Util.ToList(activeSharedFolders1Day);

            if (activeSharedFolders1Day == null)
            {
                throw new sys.ArgumentNullException("activeSharedFolders1Day");
            }

            var sharedLinksCreatedList = enc.Util.ToList(sharedLinksCreated);

            if (sharedLinksCreated == null)
            {
                throw new sys.ArgumentNullException("sharedLinksCreated");
            }

            var sharedLinksViewedByTeamList = enc.Util.ToList(sharedLinksViewedByTeam);

            if (sharedLinksViewedByTeam == null)
            {
                throw new sys.ArgumentNullException("sharedLinksViewedByTeam");
            }

            var sharedLinksViewedByOutsideUserList = enc.Util.ToList(sharedLinksViewedByOutsideUser);

            if (sharedLinksViewedByOutsideUser == null)
            {
                throw new sys.ArgumentNullException("sharedLinksViewedByOutsideUser");
            }

            var sharedLinksViewedByNotLoggedInList = enc.Util.ToList(sharedLinksViewedByNotLoggedIn);

            if (sharedLinksViewedByNotLoggedIn == null)
            {
                throw new sys.ArgumentNullException("sharedLinksViewedByNotLoggedIn");
            }

            var sharedLinksViewedTotalList = enc.Util.ToList(sharedLinksViewedTotal);

            if (sharedLinksViewedTotal == null)
            {
                throw new sys.ArgumentNullException("sharedLinksViewedTotal");
            }

            this.Adds = addsList;
            this.Edits = editsList;
            this.Deletes = deletesList;
            this.ActiveUsers28Day = activeUsers28DayList;
            this.ActiveUsers7Day = activeUsers7DayList;
            this.ActiveUsers1Day = activeUsers1DayList;
            this.ActiveSharedFolders28Day = activeSharedFolders28DayList;
            this.ActiveSharedFolders7Day = activeSharedFolders7DayList;
            this.ActiveSharedFolders1Day = activeSharedFolders1DayList;
            this.SharedLinksCreated = sharedLinksCreatedList;
            this.SharedLinksViewedByTeam = sharedLinksViewedByTeamList;
            this.SharedLinksViewedByOutsideUser = sharedLinksViewedByOutsideUserList;
            this.SharedLinksViewedByNotLoggedIn = sharedLinksViewedByNotLoggedInList;
            this.SharedLinksViewedTotal = sharedLinksViewedTotalList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetActivityReport" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GetActivityReport()
        {
        }

        /// <summary>
        /// <para>Array of total number of adds by team members.</para>
        /// </summary>
        public col.IList<ulong?> Adds { get; protected set; }

        /// <summary>
        /// <para>Array of number of edits by team members. If the same user edits the same
        /// file multiple times this is counted as a single edit.</para>
        /// </summary>
        public col.IList<ulong?> Edits { get; protected set; }

        /// <summary>
        /// <para>Array of total number of deletes by team members.</para>
        /// </summary>
        public col.IList<ulong?> Deletes { get; protected set; }

        /// <summary>
        /// <para>Array of the number of users who have been active in the last 28 days.</para>
        /// </summary>
        public col.IList<ulong?> ActiveUsers28Day { get; protected set; }

        /// <summary>
        /// <para>Array of the number of users who have been active in the last week.</para>
        /// </summary>
        public col.IList<ulong?> ActiveUsers7Day { get; protected set; }

        /// <summary>
        /// <para>Array of the number of users who have been active in the last day.</para>
        /// </summary>
        public col.IList<ulong?> ActiveUsers1Day { get; protected set; }

        /// <summary>
        /// <para>Array of the number of shared folders with some activity in the last 28
        /// days.</para>
        /// </summary>
        public col.IList<ulong?> ActiveSharedFolders28Day { get; protected set; }

        /// <summary>
        /// <para>Array of the number of shared folders with some activity in the last
        /// week.</para>
        /// </summary>
        public col.IList<ulong?> ActiveSharedFolders7Day { get; protected set; }

        /// <summary>
        /// <para>Array of the number of shared folders with some activity in the last
        /// day.</para>
        /// </summary>
        public col.IList<ulong?> ActiveSharedFolders1Day { get; protected set; }

        /// <summary>
        /// <para>Array of the number of shared links created.</para>
        /// </summary>
        public col.IList<ulong?> SharedLinksCreated { get; protected set; }

        /// <summary>
        /// <para>Array of the number of views by team users to shared links created by the
        /// team.</para>
        /// </summary>
        public col.IList<ulong?> SharedLinksViewedByTeam { get; protected set; }

        /// <summary>
        /// <para>Array of the number of views by users outside of the team to shared links
        /// created by the team.</para>
        /// </summary>
        public col.IList<ulong?> SharedLinksViewedByOutsideUser { get; protected set; }

        /// <summary>
        /// <para>Array of the number of views by non-logged-in users to shared links created
        /// by the team.</para>
        /// </summary>
        public col.IList<ulong?> SharedLinksViewedByNotLoggedIn { get; protected set; }

        /// <summary>
        /// <para>Array of the total number of views to shared links created by the
        /// team.</para>
        /// </summary>
        public col.IList<ulong?> SharedLinksViewedTotal { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetActivityReport" />.</para>
        /// </summary>
        private class GetActivityReportEncoder : enc.StructEncoder<GetActivityReport>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetActivityReport value, enc.IJsonWriter writer)
            {
                WriteProperty("start_date", value.StartDate, writer, enc.StringEncoder.Instance);
                WriteListProperty("adds", value.Adds, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("edits", value.Edits, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("deletes", value.Deletes, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("active_users_28_day", value.ActiveUsers28Day, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("active_users_7_day", value.ActiveUsers7Day, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("active_users_1_day", value.ActiveUsers1Day, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("active_shared_folders_28_day", value.ActiveSharedFolders28Day, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("active_shared_folders_7_day", value.ActiveSharedFolders7Day, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("active_shared_folders_1_day", value.ActiveSharedFolders1Day, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("shared_links_created", value.SharedLinksCreated, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("shared_links_viewed_by_team", value.SharedLinksViewedByTeam, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("shared_links_viewed_by_outside_user", value.SharedLinksViewedByOutsideUser, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("shared_links_viewed_by_not_logged_in", value.SharedLinksViewedByNotLoggedIn, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("shared_links_viewed_total", value.SharedLinksViewedTotal, writer, enc.UInt64Encoder.NullableInstance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetActivityReport" />.</para>
        /// </summary>
        private class GetActivityReportDecoder : enc.StructDecoder<GetActivityReport>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetActivityReport" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetActivityReport Create()
            {
                return new GetActivityReport();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GetActivityReport value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "start_date":
                        value.StartDate = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "adds":
                        value.Adds = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "edits":
                        value.Edits = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "deletes":
                        value.Deletes = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "active_users_28_day":
                        value.ActiveUsers28Day = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "active_users_7_day":
                        value.ActiveUsers7Day = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "active_users_1_day":
                        value.ActiveUsers1Day = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "active_shared_folders_28_day":
                        value.ActiveSharedFolders28Day = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "active_shared_folders_7_day":
                        value.ActiveSharedFolders7Day = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "active_shared_folders_1_day":
                        value.ActiveSharedFolders1Day = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "shared_links_created":
                        value.SharedLinksCreated = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "shared_links_viewed_by_team":
                        value.SharedLinksViewedByTeam = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "shared_links_viewed_by_outside_user":
                        value.SharedLinksViewedByOutsideUser = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "shared_links_viewed_by_not_logged_in":
                        value.SharedLinksViewedByNotLoggedIn = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "shared_links_viewed_total":
                        value.SharedLinksViewedTotal = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
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
