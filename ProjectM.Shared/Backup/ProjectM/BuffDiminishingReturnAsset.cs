// Decompiled with JetBrains decompiler
// Type: ProjectM.BuffDiminishingReturnAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class BuffDiminishingReturnAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_DiminishingReturnBuff;
    private static readonly IntPtr NativeFieldInfoPtr_Elements;
    private static readonly IntPtr NativeFieldInfoPtr_AllowOnUnitTarget;
    private static readonly IntPtr NativeFieldInfoPtr_AllowFromUnitOwner;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726387, RefRangeEnd = 726388, XrefRangeStart = 726373, XrefRangeEnd = 726387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(
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
      IL2CPP.il2cpp_runtime_invoke(BuffDiminishingReturnAsset.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuffDiminishingReturnAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffDiminishingReturnAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffDiminishingReturnAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuffDiminishingReturnAsset()
    {
      Il2CppClassPointerStore<BuffDiminishingReturnAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BuffDiminishingReturnAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffDiminishingReturnAsset>.NativeClassPtr);
      BuffDiminishingReturnAsset.NativeFieldInfoPtr_DiminishingReturnBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffDiminishingReturnAsset>.NativeClassPtr, nameof (DiminishingReturnBuff));
      BuffDiminishingReturnAsset.NativeFieldInfoPtr_Elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffDiminishingReturnAsset>.NativeClassPtr, nameof (Elements));
      BuffDiminishingReturnAsset.NativeFieldInfoPtr_AllowOnUnitTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffDiminishingReturnAsset>.NativeClassPtr, nameof (AllowOnUnitTarget));
      BuffDiminishingReturnAsset.NativeFieldInfoPtr_AllowFromUnitOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffDiminishingReturnAsset>.NativeClassPtr, nameof (AllowFromUnitOwner));
      BuffDiminishingReturnAsset.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffDiminishingReturnAsset>.NativeClassPtr, 100664199);
      BuffDiminishingReturnAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffDiminishingReturnAsset>.NativeClassPtr, 100664200);
    }

    public BuffDiminishingReturnAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> DiminishingReturnBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffDiminishingReturnAsset.NativeFieldInfoPtr_DiminishingReturnBuff));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffDiminishingReturnAsset.NativeFieldInfoPtr_DiminishingReturnBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<DiminishingReturnElement> Elements
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffDiminishingReturnAsset.NativeFieldInfoPtr_Elements));
        return pointer == IntPtr.Zero ? (List<DiminishingReturnElement>) null : new List<DiminishingReturnElement>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffDiminishingReturnAsset.NativeFieldInfoPtr_Elements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool AllowOnUnitTarget
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffDiminishingReturnAsset.NativeFieldInfoPtr_AllowOnUnitTarget));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffDiminishingReturnAsset.NativeFieldInfoPtr_AllowOnUnitTarget)) = value;
      }
    }

    public unsafe bool AllowFromUnitOwner
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffDiminishingReturnAsset.NativeFieldInfoPtr_AllowFromUnitOwner));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffDiminishingReturnAsset.NativeFieldInfoPtr_AllowFromUnitOwner)) = value;
      }
    }
  }
}
