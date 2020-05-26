#----------------------------------------------------------------
# Generated CMake target import file for configuration "Release".
#----------------------------------------------------------------

# Commands may need to know the format version.
set(CMAKE_IMPORT_FILE_VERSION 1)

# Import target "leptonica" for configuration "Release"
set_property(TARGET leptonica APPEND PROPERTY IMPORTED_CONFIGURATIONS RELEASE)
set_target_properties(leptonica PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_RELEASE "CXX"
  IMPORTED_LINK_INTERFACE_LIBRARIES_RELEASE "C:/vcpkg/installed/x64-windows-static/debug/lib/gif.lib;C:/vcpkg/installed/x64-windows-static/lib/jpeg.lib;C:/vcpkg/installed/x64-windows-static/lib/libpng16.lib;C:/vcpkg/installed/x64-windows-static/lib/zlib.lib;C:/vcpkg/installed/x64-windows-static/lib/tiff.lib;C:/vcpkg/installed/x64-windows-static/lib/lzma.lib;C:/vcpkg/installed/x64-windows-static/lib/jpeg.lib;C:/vcpkg/installed/x64-windows-static/lib/zlib.lib;C:/vcpkg/installed/x64-windows-static/lib/zlib.lib"
  IMPORTED_LOCATION_RELEASE "${_IMPORT_PREFIX}/lib/leptonica-1.80.0.lib"
  )

list(APPEND _IMPORT_CHECK_TARGETS leptonica )
list(APPEND _IMPORT_CHECK_FILES_FOR_leptonica "${_IMPORT_PREFIX}/lib/leptonica-1.80.0.lib" )

# Commands beyond this point should not need to know the version.
set(CMAKE_IMPORT_FILE_VERSION)
