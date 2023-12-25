// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelState
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Hybrid
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HybridModelState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Visibility;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    [FieldOffset(0)]
    public HybridModelState.VisibilityState Visibility;
    [FieldOffset(8)]
    public HybridModelState.PositionState Position;

    static HybridModelState()
    {
      Il2CppClassPointerStore<HybridModelState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModelState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelState>.NativeClassPtr);
      HybridModelState.NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelState>.NativeClassPtr, nameof (Visibility));
      HybridModelState.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelState>.NativeClassPtr, nameof (Position));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelState>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct VisibilityState
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Initialized;
      private static readonly System.IntPtr NativeFieldInfoPtr_Visible;
      private static readonly System.IntPtr NativeFieldInfoPtr_DoFading;
      private static readonly System.IntPtr NativeFieldInfoPtr_Occluded;
      private static readonly System.IntPtr NativeFieldInfoPtr_Alpha;
      private static readonly System.IntPtr NativeMethodInfoPtr_IsSameVisibility_Public_Boolean_byref_VisibilityState_0;
      [FieldOffset(0)]
      public bool Initialized;
      [FieldOffset(1)]
      public bool Visible;
      [FieldOffset(2)]
      public bool DoFading;
      [FieldOffset(3)]
      public bool Occluded;
      [FieldOffset(4)]
      public float Alpha;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1157483, RefRangeEnd = 1157484, XrefRangeStart = 1157483, XrefRangeEnd = 1157483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool IsSameVisibility([In] ref HybridModelState.VisibilityState newState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref newState;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelState.VisibilityState.NativeMethodInfoPtr_IsSameVisibility_Public_Boolean_byref_VisibilityState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static VisibilityState()
      {
        Il2CppClassPointerStore<HybridModelState.VisibilityState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelState>.NativeClassPtr, nameof (VisibilityState));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelState.VisibilityState>.NativeClassPtr);
        HybridModelState.VisibilityState.NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelState.VisibilityState>.NativeClassPtr, nameof (Initialized));
        HybridModelState.VisibilityState.NativeFieldInfoPtr_Visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelState.VisibilityState>.NativeClassPtr, nameof (Visible));
        HybridModelState.VisibilityState.NativeFieldInfoPtr_DoFading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelState.VisibilityState>.NativeClassPtr, nameof (DoFading));
        HybridModelState.VisibilityState.NativeFieldInfoPtr_Occluded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelState.VisibilityState>.NativeClassPtr, nameof (Occluded));
        HybridModelState.VisibilityState.NativeFieldInfoPtr_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelState.VisibilityState>.NativeClassPtr, nameof (Alpha));
        HybridModelState.VisibilityState.NativeMethodInfoPtr_IsSameVisibility_Public_Boolean_byref_VisibilityState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelState.VisibilityState>.NativeClassPtr, 100692145);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelState.VisibilityState>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PositionState
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalToWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_PositionWithOffset;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsMounted;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsRagdollDriven;
      private static readonly System.IntPtr NativeMethodInfoPtr_IsSamePosition_Public_Boolean_byref_PositionState_0;
      [FieldOffset(0)]
      public LocalToWorld LocalToWorld;
      [FieldOffset(64)]
      public float3 PositionWithOffset;
      [FieldOffset(76)]
      public bool IsMounted;
      [FieldOffset(77)]
      public bool IsRagdollDriven;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1157486, RefRangeEnd = 1157487, XrefRangeStart = 1157484, XrefRangeEnd = 1157486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool IsSamePosition([In] ref HybridModelState.PositionState newState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref newState;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelState.PositionState.NativeMethodInfoPtr_IsSamePosition_Public_Boolean_byref_PositionState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static PositionState()
      {
        Il2CppClassPointerStore<HybridModelState.PositionState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelState>.NativeClassPtr, nameof (PositionState));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelState.PositionState>.NativeClassPtr);
        HybridModelState.PositionState.NativeFieldInfoPtr_LocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelState.PositionState>.NativeClassPtr, nameof (LocalToWorld));
        HybridModelState.PositionState.NativeFieldInfoPtr_PositionWithOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelState.PositionState>.NativeClassPtr, nameof (PositionWithOffset));
        HybridModelState.PositionState.NativeFieldInfoPtr_IsMounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelState.PositionState>.NativeClassPtr, nameof (IsMounted));
        HybridModelState.PositionState.NativeFieldInfoPtr_IsRagdollDriven = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelState.PositionState>.NativeClassPtr, nameof (IsRagdollDriven));
        HybridModelState.PositionState.NativeMethodInfoPtr_IsSamePosition_Public_Boolean_byref_PositionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelState.PositionState>.NativeClassPtr, 100692146);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelState.PositionState>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
