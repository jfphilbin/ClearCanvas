#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Xml;
    using ClearCanvas.Dicom;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;
    using ClearCanvas.ImageServer.Enterprise.Command;
    using ClearCanvas.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class Series: ServerEntity
    {
        #region Constructors
        public Series():base("Series")
        {}
        public Series(
             ServerEntityKey _serverPartitionKey_
            ,ServerEntityKey _studyKey_
            ,String _seriesInstanceUid_
            ,String _modality_
            ,Int32 _numberOfSeriesRelatedInstances_
            ,String _performedProcedureStepStartDate_
            ,String _performedProcedureStepStartTime_
            ,String _sourceApplicationEntityTitle_
            ,String _seriesNumber_
            ,String _seriesDescription_
            ):base("Series")
        {
            ServerPartitionKey = _serverPartitionKey_;
            StudyKey = _studyKey_;
            SeriesInstanceUid = _seriesInstanceUid_;
            Modality = _modality_;
            NumberOfSeriesRelatedInstances = _numberOfSeriesRelatedInstances_;
            PerformedProcedureStepStartDate = _performedProcedureStepStartDate_;
            PerformedProcedureStepStartTime = _performedProcedureStepStartTime_;
            SourceApplicationEntityTitle = _sourceApplicationEntityTitle_;
            SeriesNumber = _seriesNumber_;
            SeriesDescription = _seriesDescription_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="ServerPartitionGUID")]
        public ServerEntityKey ServerPartitionKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="StudyGUID")]
        public ServerEntityKey StudyKey
        { get; set; }
        [DicomField(DicomTags.SeriesInstanceUid, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="SeriesInstanceUid")]
        public String SeriesInstanceUid
        { get; set; }
        [DicomField(DicomTags.Modality, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="Modality")]
        public String Modality
        { get; set; }
        [DicomField(DicomTags.NumberOfSeriesRelatedInstances, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="NumberOfSeriesRelatedInstances")]
        public Int32 NumberOfSeriesRelatedInstances
        { get; set; }
        [DicomField(DicomTags.PerformedProcedureStepStartDate, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="PerformedProcedureStepStartDate")]
        public String PerformedProcedureStepStartDate
        { get; set; }
        [DicomField(DicomTags.PerformedProcedureStepStartTime, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="PerformedProcedureStepStartTime")]
        public String PerformedProcedureStepStartTime
        { get; set; }
        [DicomField(DicomTags.SourceApplicationEntityTitle, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="SourceApplicationEntityTitle")]
        public String SourceApplicationEntityTitle
        { get; set; }
        [DicomField(DicomTags.SeriesNumber, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="SeriesNumber")]
        public String SeriesNumber
        { get; set; }
        [DicomField(DicomTags.SeriesDescription, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="SeriesDescription")]
        public String SeriesDescription
        { get; set; }
        #endregion

        #region Static Methods
        static public Series Load(ServerEntityKey key)
        {
            using (var context = new ServerExecutionContext())
            {
                return Load(context.ReadContext, key);
            }
        }
        static public Series Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<ISeriesEntityBroker>();
            Series theObject = broker.Load(key);
            return theObject;
        }
        static public Series Insert(Series entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                Series newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public Series Insert(IUpdateContext update, Series entity)
        {
            var broker = update.GetBroker<ISeriesEntityBroker>();
            var updateColumns = new SeriesUpdateColumns();
            updateColumns.ServerPartitionKey = entity.ServerPartitionKey;
            updateColumns.StudyKey = entity.StudyKey;
            updateColumns.SeriesInstanceUid = entity.SeriesInstanceUid;
            updateColumns.Modality = entity.Modality;
            updateColumns.NumberOfSeriesRelatedInstances = entity.NumberOfSeriesRelatedInstances;
            updateColumns.PerformedProcedureStepStartDate = entity.PerformedProcedureStepStartDate;
            updateColumns.PerformedProcedureStepStartTime = entity.PerformedProcedureStepStartTime;
            updateColumns.SourceApplicationEntityTitle = entity.SourceApplicationEntityTitle;
            updateColumns.SeriesNumber = entity.SeriesNumber;
            updateColumns.SeriesDescription = entity.SeriesDescription;
            Series newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
