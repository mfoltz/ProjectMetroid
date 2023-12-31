// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.BresenhamSuperCoverLineTraversal
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BresenhamSuperCoverLineTraversal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_Delta;
    private static readonly System.IntPtr NativeFieldInfoPtr_Vector;
    private static readonly System.IntPtr NativeFieldInfoPtr_DoubleCoverMargin;
    private static readonly System.IntPtr NativeFieldInfoPtr_P;
    private static readonly System.IntPtr NativeFieldInfoPtr_S;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Current;
    private static readonly System.IntPtr NativeFieldInfoPtr_Iteration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Error;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastError;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryStep_Public_Boolean_byref_FixedList32_1_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
    [FieldOffset(0)]
    public readonly int2 Start;
    [FieldOffset(8)]
    public readonly int2 Delta;
    [FieldOffset(16)]
    public readonly int2 Vector;
    [FieldOffset(24)]
    public readonly int2 DoubleCoverMargin;
    [FieldOffset(32)]
    public readonly int P;
    [FieldOffset(36)]
    public readonly int S;
    [FieldOffset(40)]
    public readonly int StepCount;
    [FieldOffset(44)]
    public int2 Current;
    [FieldOffset(52)]
    public int Iteration;
    [FieldOffset(56)]
    public int Error;
    [FieldOffset(60)]
    public int LastError;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793686, RefRangeEnd = 793687, XrefRangeStart = 793685, XrefRangeEnd = 793686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BresenhamSuperCoverLineTraversal(int2 from, int2 to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BresenhamSuperCoverLineTraversal.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793708, RefRangeEnd = 793709, XrefRangeStart = 793687, XrefRangeEnd = 793708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryStep(out FixedList32<int2> subSteps)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref subSteps;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BresenhamSuperCoverLineTraversal.NativeMethodInfoPtr_TryStep_Public_Boolean_byref_FixedList32_1_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793709, RefRangeEnd = 793710, XrefRangeStart = 793709, XrefRangeEnd = 793709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BresenhamSuperCoverLineTraversal.NativeMethodInfoPtr_Reset_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BresenhamSuperCoverLineTraversal()
    {
      Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (BresenhamSuperCoverLineTraversal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr);
      BresenhamSuperCoverLineTraversal.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, nameof (Start));
      BresenhamSuperCoverLineTraversal.NativeFieldInfoPtr_Delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, nameof (Delta));
      BresenhamSuperCoverLineTraversal.NativeFieldInfoPtr_Vector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, nameof (Vector));
      BresenhamSuperCoverLineTraversal.NativeFieldInfoPtr_DoubleCoverMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, nameof (DoubleCoverMargin));
      BresenhamSuperCoverLineTraversal.NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, nameof (P));
      BresenhamSuperCoverLineTraversal.NativeFieldInfoPtr_S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, nameof (S));
      BresenhamSuperCoverLineTraversal.NativeFieldInfoPtr_StepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, nameof (StepCount));
      BresenhamSuperCoverLineTraversal.NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, nameof (Current));
      BresenhamSuperCoverLineTraversal.NativeFieldInfoPtr_Iteration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, nameof (Iteration));
      BresenhamSuperCoverLineTraversal.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, nameof (Error));
      BresenhamSuperCoverLineTraversal.NativeFieldInfoPtr_LastError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, nameof (LastError));
      BresenhamSuperCoverLineTraversal.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, 100669948);
      BresenhamSuperCoverLineTraversal.NativeMethodInfoPtr_TryStep_Public_Boolean_byref_FixedList32_1_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, 100669949);
      BresenhamSuperCoverLineTraversal.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, 100669950);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BresenhamSuperCoverLineTraversal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
