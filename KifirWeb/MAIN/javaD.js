document.addEventListener('DOMContentLoaded', function () {
 
    var jsonData = [
        {
          "OM_Azonosito": "78655218932",
          "Neve": "Szabó Anna",
          "ErtesitesiCime": "Budapest, Gellért tér 15.",
          "Email": "anna@example.com",
          "SzuletesiDatum": "1998-07-19T00:00:00",
          "Matematika": 14,
          "Magyar": 35
        },
        {
          "OM_Azonosito": "15963702584",
          "Neve": "Nagy Zsófia",
          "ErtesitesiCime": "Debrecen, Szent István utca 8.",
          "Email": "zsofia@example.com",
          "SzuletesiDatum": "2000-02-22T00:00:00",
          "Matematika": 27,
          "Magyar": 4
        },
        {
          "OM_Azonosito": "30351479261",
          "Neve": "Kovács Máté",
          "ErtesitesiCime": "Szeged, Erzsébet körút 45.",
          "Email": "mate@example.com",
          "SzuletesiDatum": "1995-11-29T00:00:00",
          "Matematika": 48,
          "Magyar": 15
        },
        {
          "OM_Azonosito": "97401028543",
          "Neve": "Tóth Bence",
          "ErtesitesiCime": "Pécs, Váci utca 33.",
          "Email": "bence@example.com",
          "SzuletesiDatum": "1997-03-17T00:00:00",
          "Matematika": 8,
          "Magyar": 47
        },
        {
          "OM_Azonosito": "88765031624",
          "Neve": "Horváth Eszter",
          "ErtesitesiCime": "Székesfehérvár, Bartók Béla út 12.",
          "Email": "eszter@example.com",
          "SzuletesiDatum": "1996-09-08T00:00:00",
          "Matematika": 34,
          "Magyar": 7
        },
        {
          "OM_Azonosito": "64189075351",
          "Neve": "Kiss Attila",
          "ErtesitesiCime": "Miskolc, József Attila utca 18.",
          "Email": "attila@example.com",
          "SzuletesiDatum": "1993-12-05T00:00:00",
          "Matematika": 13,
          "Magyar": 48
        },
        {
          "OM_Azonosito": "18734250658",
          "Neve": "Fekete Laura",
          "ErtesitesiCime": "Győr, Széchenyi tér 9.",
          "Email": "laura@example.com",
          "SzuletesiDatum": "1999-06-30T00:00:00",
          "Matematika": 2,
          "Magyar": 30
        },
        {
          "OM_Azonosito": "51698072427",
          "Neve": "Bíró Gábor",
          "ErtesitesiCime": "Kecskemét, Deák Ferenc utca 21.",
          "Email": "gabor@example.com",
          "SzuletesiDatum": "1994-10-14T00:00:00",
          "Matematika": 9,
          "Magyar": 33
        },
        {
          "OM_Azonosito": "60157349268",
          "Neve": "Mészáros Péter",
          "ErtesitesiCime": "Nyíregyháza, Petőfi Sándor utca 26.",
          "Email": "peter@example.com",
          "SzuletesiDatum": "2001-04-01T00:00:00",
          "Matematika": 36,
          "Magyar": 21
        },
        {
          "OM_Azonosito": "72948316750",
          "Neve": "Varga Noémi",
          "ErtesitesiCime": "Szombathely, Kossuth Lajos utca 3.",
          "Email": "noemi@example.com",
          "SzuletesiDatum": "1992-08-18T00:00:00",
          "Matematika": 24,
          "Magyar": 23
        },
        {
          "OM_Azonosito": "84052731649",
          "Neve": "Lakatos Dóra",
          "ErtesitesiCime": "Veszprém, Ady Endre utca 7.",
          "Email": "dora@example.com",
          "SzuletesiDatum": "2000-01-03T00:00:00",
          "Matematika": 43,
          "Magyar": 41
        },
        {
          "OM_Azonosito": "85273941680",
          "Neve": "Németh Tamás",
          "ErtesitesiCime": "Szolnok, Béke tér 14.",
          "Email": "tamas@example.com",
          "SzuletesiDatum": "1998-05-27T00:00:00",
          "Matematika": 5,
          "Magyar": 49
        },
        {
          "OM_Azonosito": "41593260701",
          "Neve": "Orbán Katalin",
          "ErtesitesiCime": "Eger, Szabadság utca 32.",
          "Email": "katalin@example.com",
          "SzuletesiDatum": "1996-02-11T00:00:00",
          "Matematika": 37,
          "Magyar": 20
        },
        {
          "OM_Azonosito": "10486732952",
          "Neve": "Simon Balázs",
          "ErtesitesiCime": "Debrecen, Király utca 28.",
          "Email": "balazs@example.com",
          "SzuletesiDatum": "1995-07-07T00:00:00",
          "Matematika": 20,
          "Magyar": 48
        },
        {
          "OM_Azonosito": "92740581643",
          "Neve": "Papp Viktória",
          "ErtesitesiCime": "Kaposvár, Alkotmány utca 5.",
          "Email": "viktor@example.com",
          "SzuletesiDatum": "1997-11-24T00:00:00",
          "Matematika": 32,
          "Magyar": 9
        },
        {
          "OM_Azonosito": "10637851454",
          "Neve": "Molnár Zoltán",
          "ErtesitesiCime": "Szekszárd, Párizsi utca 17.",
          "Email": "zoltan@example.com",
          "SzuletesiDatum": "1993-01-16T00:00:00",
          "Matematika": 3,
          "Magyar": 46
        },
        {
          "OM_Azonosito": "44025967885",
          "Neve": "Fekete Márton",
          "ErtesitesiCime": "Pécs, Rákóczi út 13.",
          "Email": "marton@example.com",
          "SzuletesiDatum": "1992-04-29T00:00:00",
          "Matematika": 42,
          "Magyar": 31
        },
        {
          "OM_Azonosito": "30381425616",
          "Neve": "Pál Júlia",
          "ErtesitesiCime": "Sopron, Szent Gellért tér 10.",
          "Email": "julia@example.com",
          "SzuletesiDatum": "1999-09-02T00:00:00",
          "Matematika": 49,
          "Magyar": 19
        },
        {
          "OM_Azonosito": "65082317920",
          "Neve": "Takács Orsolya",
          "ErtesitesiCime": "Eger, Andrássy út 22.",
          "Email": "orsolya@example.com",
          "SzuletesiDatum": "1994-06-13T00:00:00",
          "Matematika": 31,
          "Magyar": 18
        },
        {
          "OM_Azonosito": "15374680221",
          "Neve": "Kovács Ádám",
          "ErtesitesiCime": "Székesfehérvár, Bajnai út 8.",
          "Email": "adam@example.com",
          "SzuletesiDatum": "1996-08-06T00:00:00",
          "Matematika": 18,
          "Magyar": 10
        }
      ]
    

      document.getElementById("SelectedTitle").style.visibility = "hidden";
      var tableBody = document.querySelector('#jsonTable tbody');
      var minimumPontszamInput = document.getElementById('pminimum');
      var sortDirection = {};
      var filteredData = jsonData.slice(); 
      var selectedRow = null;
  
      function displayData() {
          tableBody.innerHTML = '';
  
          filteredData.forEach(function (row) {
              var osszes = row.Matematika + row.Magyar;
              var tr = document.createElement('tr');
              tr.innerHTML = '<td>' + row.OM_Azonosito + '</td>' +
                  '<td>' + row.Neve + '</td>' +
                  '<td>' + row.Matematika + '</td>' +
                  '<td>' + row.Magyar + '</td>' +
                  '<td>' + osszes + '</td>';
  
              tr.addEventListener('click', function() {
                  selectRow(row); 
              });
  
              tableBody.appendChild(tr);
          });
      }
  
      function generateCSV(row) {
    
          var csv = Object.values(row).join(';');
          return csv;
      }


      function tableToCSV() {
        var csv = '';
        var rows = document.querySelectorAll('#jsonTable tr');
    
        rows.forEach(function (row) {
            var rowData = [];
            var cols = row.querySelectorAll('td');
    
            cols.forEach(function (col) {
                rowData.push(col.textContent);
            });
    
            csv += rowData.join(';') + '\n';
        });
    
        return csv;
    }

    var saveButton = document.getElementById('btnSave');
    saveButton.addEventListener('click', function () {
      var csvContent = tableToCSV();
      if(csvContent.length > 1){
        var encodedUri = encodeURI('data:text/csv;charset=utf-8,' + csvContent);
        var link = document.createElement('a');
        link.setAttribute('href', encodedUri);
        link.setAttribute('download', 'adatok.csv');
        document.body.appendChild(link);
        link.click();
        document.body.removeChild(link);
        alert("Sikeres mentés")
      }else {
        alert("Sikertelen mentés!\n Üres tábla!")
      }
   
  

    });
      function addToSelectedList(row) {
          var selectedList = document.getElementById('selectedList');
          var listItem = document.createElement('li');
          document.getElementById("SelectedTitle").style.visibility = "visible";

          listItem.textContent = generateCSV(row); 
          selectedList.innerHTML = ''; 
          selectedList.appendChild(listItem);
          
      }
  
      function selectRow(row) {
          if (selectedRow !== null) {
              selectedRow.classList.remove('selected');
          }
          selectedRow = event.currentTarget;
          selectedRow.classList.add('selected');
          addToSelectedList(row);
      }
  
      var searchButton = document.getElementById('searchButton');
      var searchInput = document.getElementById('kereses');
      var button = document.getElementById('button');
  
      searchButton.addEventListener('click', function () {
          var searchTerm = searchInput.value.toLowerCase();
          var minimumPontszam = parseInt(minimumPontszamInput.value, 10) || 0;
          
          filteredData = jsonData.filter(function (row) {
              return row.Neve.toLowerCase().includes(searchTerm) && (row.Matematika + row.Magyar) >= minimumPontszam;
          });
          
          displayData(filteredData);
      });
      function sortByColumn(columnName) {
        filteredData.sort(function (a, b) {
            var valueA, valueB;
            if (columnName === 'Osszes') {
                valueA = a.Matematika + a.Magyar;
                valueB = b.Matematika + b.Magyar;
            } else {
                valueA = a[columnName];
                valueB = b[columnName];
            }
    
            if (valueA < valueB) {
                return sortDirection[columnName] === 'asc' ? -1 : 1;
            } else if (valueA > valueB) {
                return sortDirection[columnName] === 'asc' ? 1 : -1;
            } else {
                return 0;
            }
        });
    
        sortDirection[columnName] = sortDirection[columnName] === 'asc' ? 'desc' : 'asc';
        displayData();
    }
      var tableHeaders = document.querySelectorAll('#jsonTable th');
      tableHeaders.forEach(function (header) {
          header.addEventListener('click', function () {
              var columnName = this.getAttribute('data-column');
              
              sortByColumn(columnName);
          });
      });
      button.addEventListener('click', function () {
          var minimumPontszam = parseInt(minimumPontszamInput.value, 10) || 0;
          filteredData = jsonData.filter(function (row) {
              return row.Matematika + row.Magyar >= minimumPontszam;
          });
          displayData();
      });
  
      displayData();
  });