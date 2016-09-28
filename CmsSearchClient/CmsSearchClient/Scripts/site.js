
function SetWaitCursor() {
    $('body').css({ 'cursor': 'wait' });
}
function EndWaitCursor() {
    $('body').css({ 'cursor': 'default' });
}

$("#SearchTerm").autocomplete({
    minLength: 1,
    source: "/CmsSearchClient/SearchResultsViewer/AutocompleteSearch"
});