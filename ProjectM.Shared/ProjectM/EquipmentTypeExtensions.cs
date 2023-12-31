// Decompiled with JetBrains decompiler
// Type: ProjectM.EquipmentTypeExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM
{
  public static class EquipmentTypeExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInventoryEquipped_Public_Static_Boolean_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsServantInventoryEquipped_Public_Static_Boolean_EquipmentType_0;

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 724100, RefRangeEnd = 724113, XrefRangeStart = 724100, XrefRangeEnd = 724100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInventoryEquipped(this EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipmentTypeExtensions.NativeMethodInfoPtr_IsInventoryEquipped_Public_Static_Boolean_EquipmentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsServantInventoryEquipped(this EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipmentTypeExtensions.NativeMethodInfoPtr_IsServantInventoryEquipped_Public_Static_Boolean_EquipmentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EquipmentTypeExtensions()
    {
      Il2CppClassPointerStore<EquipmentTypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EquipmentTypeExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipmentTypeExtensions>.NativeClassPtr);
      EquipmentTypeExtensions.NativeMethodInfoPtr_IsInventoryEquipped_Public_Static_Boolean_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentTypeExtensions>.NativeClassPtr, 100664053);
      EquipmentTypeExtensions.NativeMethodInfoPtr_IsServantInventoryEquipped_Public_Static_Boolean_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentTypeExtensions>.NativeClassPtr, 100664054);
    }

    public EquipmentTypeExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
