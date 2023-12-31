// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.RoadPathfindingWeights
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public class RoadPathfindingWeights : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TypeWeights;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RoadPathfindingWeights()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadPathfindingWeights>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoadPathfindingWeights.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RoadPathfindingWeights()
    {
      Il2CppClassPointerStore<RoadPathfindingWeights>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (RoadPathfindingWeights));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadPathfindingWeights>.NativeClassPtr);
      RoadPathfindingWeights.NativeFieldInfoPtr_TypeWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfindingWeights>.NativeClassPtr, nameof (TypeWeights));
      RoadPathfindingWeights.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfindingWeights>.NativeClassPtr, 100668001);
    }

    public RoadPathfindingWeights(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<RoadPathfindingWeights.RoadTypeData> TypeWeights
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoadPathfindingWeights.NativeFieldInfoPtr_TypeWeights));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<RoadPathfindingWeights.RoadTypeData>) null : new Il2CppStructArray<RoadPathfindingWeights.RoadTypeData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoadPathfindingWeights.NativeFieldInfoPtr_TypeWeights), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct RoadTypeData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_RoadType;
      private static readonly System.IntPtr NativeFieldInfoPtr_WeightFactor;
      [FieldOffset(0)]
      public RoadType RoadType;
      [FieldOffset(4)]
      public float WeightFactor;

      static RoadTypeData()
      {
        Il2CppClassPointerStore<RoadPathfindingWeights.RoadTypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoadPathfindingWeights>.NativeClassPtr, nameof (RoadTypeData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadPathfindingWeights.RoadTypeData>.NativeClassPtr);
        RoadPathfindingWeights.RoadTypeData.NativeFieldInfoPtr_RoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfindingWeights.RoadTypeData>.NativeClassPtr, nameof (RoadType));
        RoadPathfindingWeights.RoadTypeData.NativeFieldInfoPtr_WeightFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfindingWeights.RoadTypeData>.NativeClassPtr, nameof (WeightFactor));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoadPathfindingWeights.RoadTypeData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
