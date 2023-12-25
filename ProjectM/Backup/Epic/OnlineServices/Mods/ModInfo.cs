// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Mods.ModInfo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Mods
{
  public sealed class ModInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Mods_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Type_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Mods_Public_get_Il2CppReferenceArray_1_ModIdentifier_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Mods_Public_set_Void_Il2CppReferenceArray_1_ModIdentifier_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_ModEnumerationType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_ModEnumerationType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_ModInfoInternal_0;

    public unsafe Il2CppReferenceArray<ModIdentifier> Mods
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModInfo.NativeMethodInfoPtr_get_Mods_Public_get_Il2CppReferenceArray_1_ModIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ModIdentifier>) null : new Il2CppReferenceArray<ModIdentifier>(nativeObject);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModInfo.NativeMethodInfoPtr_set_Mods_Public_set_Void_Il2CppReferenceArray_1_ModIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ModEnumerationType Type
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModInfo.NativeMethodInfoPtr_get_Type_Public_get_ModEnumerationType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ModEnumerationType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModInfo.NativeMethodInfoPtr_set_Type_Public_set_Void_ModEnumerationType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952807, XrefRangeEnd = 952809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref ModInfoInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_ModInfoInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModInfo()
    {
      Il2CppClassPointerStore<ModInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Mods", nameof (ModInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModInfo>.NativeClassPtr);
      ModInfo.NativeFieldInfoPtr__Mods_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModInfo>.NativeClassPtr, "<Mods>k__BackingField");
      ModInfo.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModInfo>.NativeClassPtr, "<Type>k__BackingField");
      ModInfo.NativeMethodInfoPtr_get_Mods_Public_get_Il2CppReferenceArray_1_ModIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfo>.NativeClassPtr, 100669370);
      ModInfo.NativeMethodInfoPtr_set_Mods_Public_set_Void_Il2CppReferenceArray_1_ModIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfo>.NativeClassPtr, 100669371);
      ModInfo.NativeMethodInfoPtr_get_Type_Public_get_ModEnumerationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfo>.NativeClassPtr, 100669372);
      ModInfo.NativeMethodInfoPtr_set_Type_Public_set_Void_ModEnumerationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfo>.NativeClassPtr, 100669373);
      ModInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_ModInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfo>.NativeClassPtr, 100669374);
    }

    public ModInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ModInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ModInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModInfo>.NativeClassPtr, data));
    }

    public unsafe Il2CppReferenceArray<ModIdentifier> _Mods_k__BackingField
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModInfo.NativeFieldInfoPtr__Mods_k__BackingField));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ModIdentifier>) null : new Il2CppReferenceArray<ModIdentifier>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModInfo.NativeFieldInfoPtr__Mods_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ModEnumerationType _Type_k__BackingField
    {
      get
      {
        return *(ModEnumerationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModInfo.NativeFieldInfoPtr__Type_k__BackingField));
      }
      [param: In] set
      {
        *(ModEnumerationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModInfo.NativeFieldInfoPtr__Type_k__BackingField)) = value;
      }
    }
  }
}
