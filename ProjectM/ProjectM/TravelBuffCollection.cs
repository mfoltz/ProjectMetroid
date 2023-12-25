// Decompiled with JetBrains decompiler
// Type: ProjectM.TravelBuffCollection
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TravelBuffCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TravelBuffs;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NativeList_1_EntityTravelBuffEndPosition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EndPositions_Public_get_NativeArray_1_EntityTravelBuffEndPosition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Register_Public_Void_byref_Entity_byref_TravelBuff_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deregister_Public_Void_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Private_Int32_byref_Entity_0;
    [FieldOffset(0)]
    public NativeList<EntityTravelBuffEndPosition> _TravelBuffs;

    [CallerCount(103)]
    [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TravelBuffCollection(
      NativeList<EntityTravelBuffEndPosition> travelBuffs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &travelBuffs;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TravelBuffCollection.NativeMethodInfoPtr__ctor_Internal_Void_NativeList_1_EntityTravelBuffEndPosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe NativeArray<EntityTravelBuffEndPosition> EndPositions
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1002065, RefRangeEnd = 1002066, XrefRangeStart = 1002062, XrefRangeEnd = 1002065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TravelBuffCollection.NativeMethodInfoPtr_get_EndPositions_Public_get_NativeArray_1_EntityTravelBuffEndPosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<EntityTravelBuffEndPosition>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1002071, RefRangeEnd = 1002073, XrefRangeStart = 1002066, XrefRangeEnd = 1002071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Register([In] ref Entity entity, [In] ref TravelBuff travelBuff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref travelBuff;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TravelBuffCollection.NativeMethodInfoPtr_Register_Public_Void_byref_Entity_byref_TravelBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1002077, RefRangeEnd = 1002078, XrefRangeStart = 1002073, XrefRangeEnd = 1002077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Deregister([In] ref Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TravelBuffCollection.NativeMethodInfoPtr_Deregister_Public_Void_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1002087, RefRangeEnd = 1002089, XrefRangeStart = 1002078, XrefRangeEnd = 1002087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int IndexOf([In] ref Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TravelBuffCollection.NativeMethodInfoPtr_IndexOf_Private_Int32_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TravelBuffCollection()
    {
      Il2CppClassPointerStore<TravelBuffCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TravelBuffCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelBuffCollection>.NativeClassPtr);
      TravelBuffCollection.NativeFieldInfoPtr__TravelBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffCollection>.NativeClassPtr, nameof (_TravelBuffs));
      TravelBuffCollection.NativeMethodInfoPtr__ctor_Internal_Void_NativeList_1_EntityTravelBuffEndPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelBuffCollection>.NativeClassPtr, 100677602);
      TravelBuffCollection.NativeMethodInfoPtr_get_EndPositions_Public_get_NativeArray_1_EntityTravelBuffEndPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelBuffCollection>.NativeClassPtr, 100677603);
      TravelBuffCollection.NativeMethodInfoPtr_Register_Public_Void_byref_Entity_byref_TravelBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelBuffCollection>.NativeClassPtr, 100677604);
      TravelBuffCollection.NativeMethodInfoPtr_Deregister_Public_Void_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelBuffCollection>.NativeClassPtr, 100677605);
      TravelBuffCollection.NativeMethodInfoPtr_IndexOf_Private_Int32_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelBuffCollection>.NativeClassPtr, 100677606);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelBuffCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
