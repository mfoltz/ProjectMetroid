// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleFloorNeighbourEnumerator
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleFloorNeighbourEnumerator
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GetPlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleFloor;
    private static readonly System.IntPtr NativeFieldInfoPtr__RequireFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentResult;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsInitialized;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComponentDataFromEntity_1_PlacementDestroyData_CastleFloor_NeighbourFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_get_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_CastleFloorNeighbourEnumerator_0;
    [FieldOffset(0)]
    public ComponentDataFromEntity<PlacementDestroyData> _GetPlacementDestroyData;
    [FieldOffset(32)]
    public CastleFloor _CastleFloor;
    [FieldOffset(140)]
    public NeighbourFilter _RequireFilter;
    [FieldOffset(144)]
    public int _CurrentCounter;
    [FieldOffset(148)]
    public CastleFloorNeighbourEnumerator.Result _CurrentResult;
    [FieldOffset(160)]
    public bool _IsInitialized;

    [CallerCount(0)]
    public unsafe CastleFloorNeighbourEnumerator(
      ComponentDataFromEntity<PlacementDestroyData> getPlacementDestroyData,
      CastleFloor castleFloor,
      NeighbourFilter requireFilter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &getPlacementDestroyData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &castleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &requireFilter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloorNeighbourEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ComponentDataFromEntity_1_PlacementDestroyData_CastleFloor_NeighbourFilter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe CastleFloorNeighbourEnumerator.Result Current
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleFloorNeighbourEnumerator.NativeMethodInfoPtr_get_Current_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleFloorNeighbourEnumerator.Result*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 794219, RefRangeEnd = 794222, XrefRangeStart = 794209, XrefRangeEnd = 794219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool MoveNext()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleFloorNeighbourEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 794222, RefRangeEnd = 794224, XrefRangeStart = 794222, XrefRangeEnd = 794222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloorNeighbourEnumerator.NativeMethodInfoPtr_Reset_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 794224, RefRangeEnd = 794226, XrefRangeStart = 794224, XrefRangeEnd = 794224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleFloorNeighbourEnumerator GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleFloorNeighbourEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_CastleFloorNeighbourEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleFloorNeighbourEnumerator*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastleFloorNeighbourEnumerator()
    {
      Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (CastleFloorNeighbourEnumerator));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr);
      CastleFloorNeighbourEnumerator.NativeFieldInfoPtr__GetPlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, nameof (_GetPlacementDestroyData));
      CastleFloorNeighbourEnumerator.NativeFieldInfoPtr__CastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, nameof (_CastleFloor));
      CastleFloorNeighbourEnumerator.NativeFieldInfoPtr__RequireFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, nameof (_RequireFilter));
      CastleFloorNeighbourEnumerator.NativeFieldInfoPtr__CurrentCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, nameof (_CurrentCounter));
      CastleFloorNeighbourEnumerator.NativeFieldInfoPtr__CurrentResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, nameof (_CurrentResult));
      CastleFloorNeighbourEnumerator.NativeFieldInfoPtr__IsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, nameof (_IsInitialized));
      CastleFloorNeighbourEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ComponentDataFromEntity_1_PlacementDestroyData_CastleFloor_NeighbourFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, 100670021);
      CastleFloorNeighbourEnumerator.NativeMethodInfoPtr_get_Current_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, 100670022);
      CastleFloorNeighbourEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, 100670023);
      CastleFloorNeighbourEnumerator.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, 100670024);
      CastleFloorNeighbourEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_CastleFloorNeighbourEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, 100670025);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Result
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
      private static readonly System.IntPtr NativeFieldInfoPtr_MatchingFilter;
      private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_Result_0;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public CardinalDirection Direction;
      [FieldOffset(9)]
      public NeighbourFilter MatchingFilter;

      [CallerCount(0)]
      public static unsafe implicit operator Entity(CastleFloorNeighbourEnumerator.Result result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &result;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleFloorNeighbourEnumerator.Result.NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_Result_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Result()
      {
        Il2CppClassPointerStore<CastleFloorNeighbourEnumerator.Result>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator>.NativeClassPtr, nameof (Result));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator.Result>.NativeClassPtr);
        CastleFloorNeighbourEnumerator.Result.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator.Result>.NativeClassPtr, nameof (Entity));
        CastleFloorNeighbourEnumerator.Result.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator.Result>.NativeClassPtr, nameof (Direction));
        CastleFloorNeighbourEnumerator.Result.NativeFieldInfoPtr_MatchingFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator.Result>.NativeClassPtr, nameof (MatchingFilter));
        CastleFloorNeighbourEnumerator.Result.NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator.Result>.NativeClassPtr, 100670026);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleFloorNeighbourEnumerator.Result>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
