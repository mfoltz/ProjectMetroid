// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileLineEnumerator
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileLineEnumerator
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Current_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__SubIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__SubSteps;
    private static readonly System.IntPtr NativeFieldInfoPtr__LineTraversal;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Current_Private_set_Void_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_TileLineEnumerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Unity_Mathematics_int2__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
    [FieldOffset(0)]
    public int2 _Current_k__BackingField;
    [FieldOffset(8)]
    public int _SubIndex;
    [FieldOffset(12)]
    public FixedList32<int2> _SubSteps;
    [FieldOffset(44)]
    public BresenhamSuperCoverLineTraversal _LineTraversal;

    public virtual unsafe int2 Current
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLineEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int2*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileLineEnumerator.NativeMethodInfoPtr_set_Current_Private_set_Void_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793669, RefRangeEnd = 793670, XrefRangeStart = 793668, XrefRangeEnd = 793669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileLineEnumerator(int2 from, int2 to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileLineEnumerator.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793673, RefRangeEnd = 793674, XrefRangeStart = 793670, XrefRangeEnd = 793673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLineEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793674, XrefRangeEnd = 793675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Reset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileLineEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793675, RefRangeEnd = 793676, XrefRangeStart = 793675, XrefRangeEnd = 793675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileLineEnumerator GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLineEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_TileLineEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileLineEnumerator*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileLineEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793676, XrefRangeEnd = 793679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLineEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793679, XrefRangeEnd = 793682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator<int2> System_Collections_Generic_IEnumerable_Unity_Mathematics_int2__GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLineEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Unity_Mathematics_int2__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator<int2>) null : new IEnumerator<int2>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793682, XrefRangeEnd = 793685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLineEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static TileLineEnumerator()
    {
      Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileLineEnumerator));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr);
      TileLineEnumerator.NativeFieldInfoPtr__Current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, "<Current>k__BackingField");
      TileLineEnumerator.NativeFieldInfoPtr__SubIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, nameof (_SubIndex));
      TileLineEnumerator.NativeFieldInfoPtr__SubSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, nameof (_SubSteps));
      TileLineEnumerator.NativeFieldInfoPtr__LineTraversal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, nameof (_LineTraversal));
      TileLineEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, 100669938);
      TileLineEnumerator.NativeMethodInfoPtr_set_Current_Private_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, 100669939);
      TileLineEnumerator.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, 100669940);
      TileLineEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, 100669941);
      TileLineEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, 100669942);
      TileLineEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_TileLineEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, 100669943);
      TileLineEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, 100669944);
      TileLineEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, 100669945);
      TileLineEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Unity_Mathematics_int2__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, 100669946);
      TileLineEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, 100669947);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileLineEnumerator>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
