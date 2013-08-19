var vmTrackingMap =  {
    SelectedItem : null,
    SelectItem : function (trackingMap) {
        vmTrackingMap.SelectedItem = trackingMap;
    },
    Save : function (trackingMap) {
        //Case add
        if (trackingMap.TrackingMapId == 0) {

        }
        else {

        }
    },
    IsNew: false,
    DataSource : ko.observableArray([]),
    LoadTrackingMap : function () {
        $.ajax({
            type: 'GET',
            url: '/api/TrackingMapAPI/GetAll',
            data: {skip:0, take:10}
        }).done(function (data) {
            vmTrackingMap.DataSource(data);
        });
    }
}