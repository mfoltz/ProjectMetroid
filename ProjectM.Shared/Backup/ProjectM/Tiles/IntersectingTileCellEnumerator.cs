// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.IntersectingTileCellEnumerator
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct IntersectingTileCellEnumerator
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Current_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentCell;
    private static readonly System.IntPtr NativeFieldInfoPtr__CellCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__MinCell;
    private static readonly System.IntPtr NativeFieldInfoPtr__Bounds;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CellIntersection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Current_Private_set_Void_CellIntersection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IntersectingTileCellEnumerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_Tiles_CellIntersection__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CellIntersection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
    [FieldOffset(0)]
    public CellIntersection _Current_k__BackingField;
    [FieldOffset(40)]
    public int2 _CurrentCell;
    [FieldOffset(48)]
    public readonly int2 _CellCount;
    [FieldOffset(56)]
    public readonly int2 _MinCell;
    [FieldOffset(64)]
    public readonly BoundsMinMax _Bounds;

    public virtual unsafe CellIntersection Current
    {
      [CallerCount(10), CachedScanResults(RefRangeStart = 683944, RefRangeEnd = 683954, XrefRangeStart = 683944, XrefRangeEnd = 683954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IntersectingTileCellEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CellIntersection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CellIntersection*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 507245, RefRangeEnd = 507254, XrefRangeStart = 507245, XrefRangeEnd = 507254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IntersectingTileCellEnumerator.NativeMethodInfoPtr_set_Current_Private_set_Void_CellIntersection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 793064, RefRangeEnd = 793066, XrefRangeStart = 793055, XrefRangeEnd = 793064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IntersectingTileCellEnumerator(BoundsMinMax bounds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &bounds;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IntersectingTileCellEnumerator.NativeMethodInfoPtr__ctor_Public_Void_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 793070, RefRangeEnd = 793077, XrefRangeStart = 793066, XrefRangeEnd = 793070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IntersectingTileCellEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793077, RefRangeEnd = 793078, XrefRangeStart = 793077, XrefRangeEnd = 793077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Reset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IntersectingTileCellEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790662, RefRangeEnd = 790663, XrefRangeStart = 790662, XrefRangeEnd = 790663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IntersectingTileCellEnumerator GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IntersectingTileCellEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_IntersectingTileCellEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(IntersectingTileCellEnumerator*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IntersectingTileCellEnumerator.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793078, XrefRangeEnd = 793081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IntersectingTileCellEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793081, XrefRangeEnd = 793084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator<CellIntersection> System_Collections_Generic_IEnumerable_ProjectM_Tiles_CellIntersection__GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IntersectingTileCellEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_Tiles_CellIntersection__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CellIntersection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator<CellIntersection>) null : new IEnumerator<CellIntersection>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793084, XrefRangeEnd = 793087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IntersectingTileCellEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static IntersectingTileCellEnumerator()
    {
      Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (IntersectingTileCellEnumerator));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr);
      IntersectingTileCellEnumerator.NativeFieldInfoPtr__Current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, "<Current>k__BackingField");
      IntersectingTileCellEnumerator.NativeFieldInfoPtr__CurrentCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, nameof (_CurrentCell));
      IntersectingTileCellEnumerator.NativeFieldInfoPtr__CellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, nameof (_CellCount));
      IntersectingTileCellEnumerator.NativeFieldInfoPtr__MinCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, nameof (_MinCell));
      IntersectingTileCellEnumerator.NativeFieldInfoPtr__Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, nameof (_Bounds));
      IntersectingTileCellEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CellIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, 100669824);
      IntersectingTileCellEnumerator.NativeMethodInfoPtr_set_Current_Private_set_Void_CellIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, 100669825);
      IntersectingTileCellEnumerator.NativeMethodInfoPtr__ctor_Public_Void_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, 100669826);
      IntersectingTileCellEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, 100669827);
      IntersectingTileCellEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, 100669828);
      IntersectingTileCellEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_IntersectingTileCellEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, 100669829);
      IntersectingTileCellEnumerator.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, 100669830);
      IntersectingTileCellEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, 100669831);
      IntersectingTileCellEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_Tiles_CellIntersection__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CellIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, 100669832);
      IntersectingTileCellEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, 100669833);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IntersectingTileCellEnumerator>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
