// Decompiled with JetBrains decompiler
// Type: ManagedAssetReference
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using System.Runtime.InteropServices;

#nullable disable
public class ManagedAssetReference : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AssetLookup;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(4981)]
  [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Clone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ManagedAssetReference.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
  }

  [CallerCount(3875)]
  [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ManagedAssetReference()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedAssetReference>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ManagedAssetReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ManagedAssetReference()
  {
    Il2CppClassPointerStore<ManagedAssetReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (ManagedAssetReference));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedAssetReference>.NativeClassPtr);
    ManagedAssetReference.NativeFieldInfoPtr_AssetLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedAssetReference>.NativeClassPtr, nameof (AssetLookup));
    ManagedAssetReference.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetReference>.NativeClassPtr, 100663302);
    ManagedAssetReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetReference>.NativeClassPtr, 100663303);
  }

  public ManagedAssetReference(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Dictionary<AssetGuid, UnityEngine.Object> AssetLookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedAssetReference.NativeFieldInfoPtr_AssetLookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<AssetGuid, UnityEngine.Object>) null : new Dictionary<AssetGuid, UnityEngine.Object>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedAssetReference.NativeFieldInfoPtr_AssetLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
