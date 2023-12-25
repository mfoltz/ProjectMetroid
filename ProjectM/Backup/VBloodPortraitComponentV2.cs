// Decompiled with JetBrains decompiler
// Type: VBloodPortraitComponentV2
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
public class VBloodPortraitComponentV2 : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_LargeStandard;
  private static readonly IntPtr NativeFieldInfoPtr_LargeEffect;
  private static readonly IntPtr NativeFieldInfoPtr_SmallStandard;
  private static readonly IntPtr NativeFieldInfoPtr_SmallEffect;
  private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915614, XrefRangeEnd = 915630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Convert(
    Entity entity,
    EntityManager dstManager,
    GameObjectConversionSystem conversionSystem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &entity;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VBloodPortraitComponentV2.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VBloodPortraitComponentV2()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodPortraitComponentV2>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VBloodPortraitComponentV2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static VBloodPortraitComponentV2()
  {
    Il2CppClassPointerStore<VBloodPortraitComponentV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (VBloodPortraitComponentV2));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodPortraitComponentV2>.NativeClassPtr);
    VBloodPortraitComponentV2.NativeFieldInfoPtr_LargeStandard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponentV2>.NativeClassPtr, nameof (LargeStandard));
    VBloodPortraitComponentV2.NativeFieldInfoPtr_LargeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponentV2>.NativeClassPtr, nameof (LargeEffect));
    VBloodPortraitComponentV2.NativeFieldInfoPtr_SmallStandard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponentV2>.NativeClassPtr, nameof (SmallStandard));
    VBloodPortraitComponentV2.NativeFieldInfoPtr_SmallEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponentV2>.NativeClassPtr, nameof (SmallEffect));
    VBloodPortraitComponentV2.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitComponentV2>.NativeClassPtr, 100663598);
    VBloodPortraitComponentV2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitComponentV2>.NativeClassPtr, 100663599);
  }

  public VBloodPortraitComponentV2(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe WeakAssetReference<Sprite> LargeStandard
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponentV2.NativeFieldInfoPtr_LargeStandard));
      return pointer == IntPtr.Zero ? (WeakAssetReference<Sprite>) null : new WeakAssetReference<Sprite>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponentV2.NativeFieldInfoPtr_LargeStandard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe WeakAssetReference<Sprite> LargeEffect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponentV2.NativeFieldInfoPtr_LargeEffect));
      return pointer == IntPtr.Zero ? (WeakAssetReference<Sprite>) null : new WeakAssetReference<Sprite>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponentV2.NativeFieldInfoPtr_LargeEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe WeakAssetReference<Sprite> SmallStandard
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponentV2.NativeFieldInfoPtr_SmallStandard));
      return pointer == IntPtr.Zero ? (WeakAssetReference<Sprite>) null : new WeakAssetReference<Sprite>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponentV2.NativeFieldInfoPtr_SmallStandard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe WeakAssetReference<Sprite> SmallEffect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponentV2.NativeFieldInfoPtr_SmallEffect));
      return pointer == IntPtr.Zero ? (WeakAssetReference<Sprite>) null : new WeakAssetReference<Sprite>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponentV2.NativeFieldInfoPtr_SmallEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
