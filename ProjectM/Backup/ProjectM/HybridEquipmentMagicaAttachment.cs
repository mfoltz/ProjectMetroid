// Decompiled with JetBrains decompiler
// Type: ProjectM.HybridEquipmentMagicaAttachment
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class HybridEquipmentMagicaAttachment : HybridEquipmentAttachment
  {
    private static readonly IntPtr NativeFieldInfoPtr_DynamicSetups;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridEquipmentMagicaAttachment()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridEquipmentMagicaAttachment>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentMagicaAttachment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridEquipmentMagicaAttachment()
    {
      Il2CppClassPointerStore<HybridEquipmentMagicaAttachment>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HybridEquipmentMagicaAttachment));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridEquipmentMagicaAttachment>.NativeClassPtr);
      HybridEquipmentMagicaAttachment.NativeFieldInfoPtr_DynamicSetups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentMagicaAttachment>.NativeClassPtr, nameof (DynamicSetups));
      HybridEquipmentMagicaAttachment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentMagicaAttachment>.NativeClassPtr, 100681873);
    }

    public HybridEquipmentMagicaAttachment(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<MagicaDynamicSetup> DynamicSetups
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentMagicaAttachment.NativeFieldInfoPtr_DynamicSetups));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<MagicaDynamicSetup>) null : new Il2CppReferenceArray<MagicaDynamicSetup>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentMagicaAttachment.NativeFieldInfoPtr_DynamicSetups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
