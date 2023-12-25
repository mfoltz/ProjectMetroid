// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastlePillarBlockCollection
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastlePillarBlockCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Pillars;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NativeHashMap_2_CastleBlock_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPillar_Public_Boolean_CastleBlock_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPillar_Public_Boolean_CastleBlock_InterCardinalDirection_byref_Entity_0;
    [FieldOffset(0)]
    public readonly NativeHashMap<CastleBlock, Entity> _Pillars;

    [CallerCount(103)]
    [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastlePillarBlockCollection(NativeHashMap<CastleBlock, Entity> pillars)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pillars;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastlePillarBlockCollection.NativeMethodInfoPtr__ctor_Internal_Void_NativeHashMap_2_CastleBlock_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1126793, RefRangeEnd = 1126798, XrefRangeStart = 1126790, XrefRangeEnd = 1126793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetPillar(CastleBlock block, out Entity pillarEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pillarEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastlePillarBlockCollection.NativeMethodInfoPtr_TryGetPillar_Public_Boolean_CastleBlock_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126798, XrefRangeEnd = 1126802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetPillar(
      CastleBlock block,
      InterCardinalDirection pillarDirection,
      out Entity pillarEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pillarDirection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref pillarEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastlePillarBlockCollection.NativeMethodInfoPtr_TryGetPillar_Public_Boolean_CastleBlock_InterCardinalDirection_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastlePillarBlockCollection()
    {
      Il2CppClassPointerStore<CastlePillarBlockCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastlePillarBlockCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastlePillarBlockCollection>.NativeClassPtr);
      CastlePillarBlockCollection.NativeFieldInfoPtr__Pillars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastlePillarBlockCollection>.NativeClassPtr, nameof (_Pillars));
      CastlePillarBlockCollection.NativeMethodInfoPtr__ctor_Internal_Void_NativeHashMap_2_CastleBlock_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastlePillarBlockCollection>.NativeClassPtr, 100689496);
      CastlePillarBlockCollection.NativeMethodInfoPtr_TryGetPillar_Public_Boolean_CastleBlock_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastlePillarBlockCollection>.NativeClassPtr, 100689497);
      CastlePillarBlockCollection.NativeMethodInfoPtr_TryGetPillar_Public_Boolean_CastleBlock_InterCardinalDirection_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastlePillarBlockCollection>.NativeClassPtr, 100689498);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastlePillarBlockCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
