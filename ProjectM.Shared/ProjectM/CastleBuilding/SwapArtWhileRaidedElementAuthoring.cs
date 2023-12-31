// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.SwapArtWhileRaidedElementAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class SwapArtWhileRaidedElementAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_OverrideMaterial;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794129, XrefRangeEnd = 794145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(SwapArtWhileRaidedElementAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SwapArtWhileRaidedElementAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwapArtWhileRaidedElementAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SwapArtWhileRaidedElementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SwapArtWhileRaidedElementAuthoring()
    {
      Il2CppClassPointerStore<SwapArtWhileRaidedElementAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (SwapArtWhileRaidedElementAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwapArtWhileRaidedElementAuthoring>.NativeClassPtr);
      SwapArtWhileRaidedElementAuthoring.NativeFieldInfoPtr_OverrideMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapArtWhileRaidedElementAuthoring>.NativeClassPtr, nameof (OverrideMaterial));
      SwapArtWhileRaidedElementAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapArtWhileRaidedElementAuthoring>.NativeClassPtr, 100670008);
      SwapArtWhileRaidedElementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapArtWhileRaidedElementAuthoring>.NativeClassPtr, 100670009);
    }

    public SwapArtWhileRaidedElementAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Material OverrideMaterial
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapArtWhileRaidedElementAuthoring.NativeFieldInfoPtr_OverrideMaterial));
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SwapArtWhileRaidedElementAuthoring.NativeFieldInfoPtr_OverrideMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
