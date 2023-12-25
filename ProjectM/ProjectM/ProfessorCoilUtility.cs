// Decompiled with JetBrains decompiler
// Type: ProjectM.ProfessorCoilUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public static class ProfessorCoilUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEvent_Public_Static_Entity_EntityManager_byref_ProfessorCoilEvent_byref_float3_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateBeam_Public_Static_Entity_Entity_byref_ProfessorCoilEvent_byref_Entity_byref_float3_Int32_byref_float3_Int32_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveCoilPair_Public_Static_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveCoilPairs_Public_Static_Void_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryMoveCoilPair_Public_Static_Boolean_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_Int32_Int32_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 996303, RefRangeEnd = 996305, XrefRangeStart = 996263, XrefRangeEnd = 996303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateEvent(
      EntityManager entityManager,
      [In] ref ProfessorCoilEvent evt,
      [In] ref float3 position,
      Entity owner)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &owner;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilUtility.NativeMethodInfoPtr_CreateEvent_Public_Static_Entity_EntityManager_byref_ProfessorCoilEvent_byref_float3_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 996315, RefRangeEnd = 996316, XrefRangeStart = 996305, XrefRangeEnd = 996315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateBeam(
      Entity prefab,
      [In] ref ProfessorCoilEvent evt,
      [In] ref Entity eventEntity,
      [In] ref float3 coil0Position,
      int coil0Index,
      [In] ref float3 coil1Position,
      int coil1Index,
      EntityCommandBuffer ecb)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &prefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref coil0Position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &coil0Index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref coil1Position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &coil1Index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &ecb;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilUtility.NativeMethodInfoPtr_CreateBeam_Public_Static_Entity_Entity_byref_ProfessorCoilEvent_byref_Entity_byref_float3_Int32_byref_float3_Int32_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 996325, RefRangeEnd = 996326, XrefRangeStart = 996316, XrefRangeEnd = 996325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ProfessorCoilPairElement MoveCoilPair(
      ref DynamicBuffer<ProfessorCoilPairElement> from,
      ref DynamicBuffer<ProfessorCoilPairElement> to,
      int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilUtility.NativeMethodInfoPtr_MoveCoilPair_Public_Static_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProfessorCoilPairElement*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 996335, RefRangeEnd = 996336, XrefRangeStart = 996326, XrefRangeEnd = 996335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void MoveCoilPairs(
      ref DynamicBuffer<ProfessorCoilPairElement> from,
      ref DynamicBuffer<ProfessorCoilPairElement> to,
      int startIndex,
      int count)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilUtility.NativeMethodInfoPtr_MoveCoilPairs_Public_Static_Void_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 996342, RefRangeEnd = 996344, XrefRangeStart = 996336, XrefRangeEnd = 996342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryMoveCoilPair(
      ref DynamicBuffer<ProfessorCoilPairElement> from,
      ref DynamicBuffer<ProfessorCoilPairElement> to,
      int coilIndex0,
      int coilIndex1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &coilIndex0;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &coilIndex1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilUtility.NativeMethodInfoPtr_TryMoveCoilPair_Public_Static_Boolean_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ProfessorCoilUtility()
    {
      Il2CppClassPointerStore<ProfessorCoilUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProfessorCoilUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilUtility>.NativeClassPtr);
      ProfessorCoilUtility.NativeMethodInfoPtr_CreateEvent_Public_Static_Entity_EntityManager_byref_ProfessorCoilEvent_byref_float3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilUtility>.NativeClassPtr, 100676989);
      ProfessorCoilUtility.NativeMethodInfoPtr_CreateBeam_Public_Static_Entity_Entity_byref_ProfessorCoilEvent_byref_Entity_byref_float3_Int32_byref_float3_Int32_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilUtility>.NativeClassPtr, 100676990);
      ProfessorCoilUtility.NativeMethodInfoPtr_MoveCoilPair_Public_Static_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilUtility>.NativeClassPtr, 100676991);
      ProfessorCoilUtility.NativeMethodInfoPtr_MoveCoilPairs_Public_Static_Void_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilUtility>.NativeClassPtr, 100676992);
      ProfessorCoilUtility.NativeMethodInfoPtr_TryMoveCoilPair_Public_Static_Boolean_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilUtility>.NativeClassPtr, 100676993);
    }

    public ProfessorCoilUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
