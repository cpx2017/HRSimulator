function InspectLock() {
    var i = 1;
    if (i == 0) {
        $(document).bind("contextmenu", function (e) {
            swal(
                {
                    text: 'Right-Click was disabled from this site for system security reason. To Cut, Copy or Paste any text Please use following shortcut (Ctrl + X), (Ctrl + C) or (Ctrl + V).',
                    type: 'info',
                    showCancelButton: false,
                    confirmButtonClass: 'btn btn-success'
                }
            )
            e.preventDefault();
        });
        $(document).keydown(function (e) {
            if (e.which === 123) {
                swal(
                    {
                        text: 'Inspect Element was disabled from this site for system security reason.',
                        type: 'info',
                        showCancelButton: false,
                        confirmButtonClass: 'btn btn-success'
                    }
                )
                return false;
            }
        });
    }
}