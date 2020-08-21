function GetItems(namespace, entity)
{
    return new Promise((resolve, reject) => {
        $.ajax({
            xhrFields: {
                withCredentials: true
            },
            crossDomain: true,
            url: "http://localhost/KadrovskaBlazorRhetos/rest/" + namespace + "/" + entity + "/",
            type: 'GET',
            success: function (data) {
                resolve(data.Records)
            },
            error: function (error) {
                reject(error)
            }
        });
    });  
}

function GetItemByID(namespace, entity, ID) {
    return new Promise((resolve, reject) => {
        $.ajax({
            xhrFields: {
                withCredentials: true
            },
            crossDomain: true,
            url: 'http://localhost/KadrovskaBlazorRhetos/rest/' + namespace + '/' + entity + '/?filters=[{"Property":"ID","Operation":"equal","Value":"' + ID + '"}]',
            type: 'GET',
            success: function (data) {
                resolve(data.Records[0])
            },
            error: function (error) {
                reject(error)
            }
        });
    });
}

function InsertItem(namespace, entity, data) {
    return new Promise((resolve, reject) => {
        $.ajax({
            url: 'http://localhost/KadrovskaBlazorRhetos/rest/' + namespace + '/' + entity + '/',
            type: 'POST',
            xhrFields: {
                withCredentials: true
            },
            data: data,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (resultData) {               
                resolve(resultData);
            },
            error: function (error) {
                reject(error)
            }
        });
    });
}

function UpdateItem(namespace, entity, data, id) {
    return new Promise((resolve, reject) => {
        $.ajax({
            url: 'http://localhost/KadrovskaBlazorRhetos/rest/' + namespace + '/' + entity + '/' +  id,
            type: 'PUT',
            xhrFields: {
                withCredentials: true
            },
            data: data,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (resultData) {               
                resolve(resultData);
            },
            error: function (error) {
                reject(error)
            }
        });
    });
}

function DeleteItem(namespace, entity, data, id) {
    return new Promise((resolve, reject) => {
        $.ajax({
            url: 'http://localhost/KadrovskaBlazorRhetos/rest/' + namespace + '/' + entity + '/' + id,
            type: 'DELETE',
            xhrFields: {
                withCredentials: true
            },
            data: data,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (resultData) {
                resolve(resultData);
            },
            error: function (error) {
                reject(error)
            }
        });
    });
}