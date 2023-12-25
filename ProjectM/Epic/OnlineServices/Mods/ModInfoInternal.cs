// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Mods.ModInfoInternal
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
  [StructLayout(LayoutKind.Explicit)]
  public struct ModInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ModsCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Mods;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Mods_Public_get_Il2CppReferenceArray_1_ModIdentifier_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Mods_Public_set_Void_Il2CppReferenceArray_1_ModIdentifier_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_ModEnumerationType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_ModEnumerationType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ModInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ModInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ModInfo_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public int m_ModsCount;
    [FieldOffset(8)]
    public System.IntPtr m_Mods;
    [FieldOffset(16)]
    public ModEnumerationType m_Type;

    public unsafe Il2CppReferenceArray<ModIdentifier> Mods
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 952815, RefRangeEnd = 952817, XrefRangeStart = 952809, XrefRangeEnd = 952815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_get_Mods_Public_get_Il2CppReferenceArray_1_ModIdentifier_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ModIdentifier>) null : new Il2CppReferenceArray<ModIdentifier>(nativeObject);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 952823, RefRangeEnd = 952825, XrefRangeStart = 952817, XrefRangeEnd = 952823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_set_Mods_Public_set_Void_Il2CppReferenceArray_1_ModIdentifier_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ModEnumerationType Type
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_get_Type_Public_get_ModEnumerationType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ModEnumerationType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_ModEnumerationType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952825, XrefRangeEnd = 952826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref ModInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ModInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952826, XrefRangeEnd = 952833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<ModInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ModInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952833, XrefRangeEnd = 952837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952837, XrefRangeEnd = 952839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out ModInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ModInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ModInfo local = ref output;
      System.IntPtr pointer = zero;
      ModInfo modInfo = pointer == System.IntPtr.Zero ? (ModInfo) null : new ModInfo(pointer);
      local = modInfo;
    }

    static ModInfoInternal()
    {
      Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Mods", nameof (ModInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr);
      ModInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
      ModInfoInternal.NativeFieldInfoPtr_m_ModsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, nameof (m_ModsCount));
      ModInfoInternal.NativeFieldInfoPtr_m_Mods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, nameof (m_Mods));
      ModInfoInternal.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, nameof (m_Type));
      ModInfoInternal.NativeMethodInfoPtr_get_Mods_Public_get_Il2CppReferenceArray_1_ModIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100669375);
      ModInfoInternal.NativeMethodInfoPtr_set_Mods_Public_set_Void_Il2CppReferenceArray_1_ModIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100669376);
      ModInfoInternal.NativeMethodInfoPtr_get_Type_Public_get_ModEnumerationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100669377);
      ModInfoInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_ModEnumerationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100669378);
      ModInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ModInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100669379);
      ModInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ModInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100669380);
      ModInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100669381);
      ModInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ModInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100669382);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
