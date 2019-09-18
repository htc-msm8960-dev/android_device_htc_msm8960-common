[AID_VENDOR_QTI_DIAG]
value:2901

[AID_VENDOR_QCOM_DIAG]
value:2950

[AID_VENDOR_RFS]
value:2951

[AID_VENDOR_RFS_SHARED]
value:2952

[firmware/]
mode: 0771
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0

[vendor/firmware_mnt/image/*]
mode: 0771
user: AID_ROOT
group: AID_SYSTEM
caps: 0

[firmware/image/*]
mode: 0771
user: AID_ROOT
group: AID_SYSTEM
caps: 0

[devlog/]
mode: 0771
user: AID_ROOT
group: AID_SYSTEM
caps: 0

[ramdump/]
mode: 0771
user: AID_ROOT
group: AID_SYSTEM
caps: 0

[persist/]
mode: 0771
user: AID_ROOT
group: AID_SYSTEM
caps: 0
