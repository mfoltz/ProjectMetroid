// Decompiled with JetBrains decompiler
// Type: ProjectM.TopdownCameraState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TopdownCameraState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Yaw;
    private static readonly System.IntPtr NativeFieldInfoPtr_PitchPercent;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Current;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastLookAtMouseOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrozenMousePanPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotatedLookAtOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_InBuildMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnableMousePanning;
    private static readonly System.IntPtr NativeFieldInfoPtr_CameraMouseLockToggle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoomSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_InstantJump;
    [FieldOffset(0)]
    public Entity LastTargetEntity;
    [FieldOffset(8)]
    public float Yaw;
    [FieldOffset(12)]
    public float PitchPercent;
    [FieldOffset(16)]
    public TopdownCameraState.LerpVariables LastTarget;
    [FieldOffset(48)]
    public TopdownCameraState.LerpVariables Target;
    [FieldOffset(80)]
    public TopdownCameraState.LerpVariables Current;
    [FieldOffset(112)]
    public float3 LastLookAtMouseOffset;
    [FieldOffset(124)]
    public float3 FrozenMousePanPosition;
    [FieldOffset(136)]
    public float3 RotatedLookAtOffset;
    [FieldOffset(148)]
    public bool InBuildMode;
    [FieldOffset(149)]
    public bool EnableMousePanning;
    [FieldOffset(150)]
    public bool CameraMouseLockToggle;
    [FieldOffset(152)]
    public ZoomSettings ZoomSettings;
    [FieldOffset(168)]
    public bool InstantJump;

    static TopdownCameraState()
    {
      Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TopdownCameraState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr);
      TopdownCameraState.NativeFieldInfoPtr_LastTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (LastTargetEntity));
      TopdownCameraState.NativeFieldInfoPtr_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (Yaw));
      TopdownCameraState.NativeFieldInfoPtr_PitchPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (PitchPercent));
      TopdownCameraState.NativeFieldInfoPtr_LastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (LastTarget));
      TopdownCameraState.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (Target));
      TopdownCameraState.NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (Current));
      TopdownCameraState.NativeFieldInfoPtr_LastLookAtMouseOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (LastLookAtMouseOffset));
      TopdownCameraState.NativeFieldInfoPtr_FrozenMousePanPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (FrozenMousePanPosition));
      TopdownCameraState.NativeFieldInfoPtr_RotatedLookAtOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (RotatedLookAtOffset));
      TopdownCameraState.NativeFieldInfoPtr_InBuildMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (InBuildMode));
      TopdownCameraState.NativeFieldInfoPtr_EnableMousePanning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (EnableMousePanning));
      TopdownCameraState.NativeFieldInfoPtr_CameraMouseLockToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (CameraMouseLockToggle));
      TopdownCameraState.NativeFieldInfoPtr_ZoomSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (ZoomSettings));
      TopdownCameraState.NativeFieldInfoPtr_InstantJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (InstantJump));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LerpVariables
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Zoom;
      private static readonly System.IntPtr NativeFieldInfoPtr_LookAtRootPos;
      private static readonly System.IntPtr NativeFieldInfoPtr_NormalizedLookAtOffset;
      private static readonly System.IntPtr NativeFieldInfoPtr_Pitch;
      private static readonly System.IntPtr NativeMethodInfoPtr_SmoothLerp_Public_Static_LerpVariables_byref_LerpVariables_byref_LerpVariables_byref_LerpVariables_Single_Boolean_byref_LerpLambdaVars_0;
      [FieldOffset(0)]
      public float Zoom;
      [FieldOffset(4)]
      public float3 LookAtRootPos;
      [FieldOffset(16)]
      public float3 NormalizedLookAtOffset;
      [FieldOffset(28)]
      public float Pitch;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 722758, RefRangeEnd = 722759, XrefRangeStart = 722745, XrefRangeEnd = 722758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe TopdownCameraState.LerpVariables SmoothLerp(
        [In] ref TopdownCameraState.LerpVariables current,
        [In] ref TopdownCameraState.LerpVariables lastTarget,
        [In] ref TopdownCameraState.LerpVariables target,
        float deltaTime,
        bool lerpOffset,
        [In] ref TopdownCamera.LerpLambdaVars lerpLambdas)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref current;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lerpOffset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref lerpLambdas;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TopdownCameraState.LerpVariables.NativeMethodInfoPtr_SmoothLerp_Public_Static_LerpVariables_byref_LerpVariables_byref_LerpVariables_byref_LerpVariables_Single_Boolean_byref_LerpLambdaVars_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TopdownCameraState.LerpVariables*) IL2CPP.il2cpp_object_unbox(num);
      }

      static LerpVariables()
      {
        Il2CppClassPointerStore<TopdownCameraState.LerpVariables>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TopdownCameraState>.NativeClassPtr, nameof (LerpVariables));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TopdownCameraState.LerpVariables>.NativeClassPtr);
        TopdownCameraState.LerpVariables.NativeFieldInfoPtr_Zoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState.LerpVariables>.NativeClassPtr, nameof (Zoom));
        TopdownCameraState.LerpVariables.NativeFieldInfoPtr_LookAtRootPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState.LerpVariables>.NativeClassPtr, nameof (LookAtRootPos));
        TopdownCameraState.LerpVariables.NativeFieldInfoPtr_NormalizedLookAtOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState.LerpVariables>.NativeClassPtr, nameof (NormalizedLookAtOffset));
        TopdownCameraState.LerpVariables.NativeFieldInfoPtr_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraState.LerpVariables>.NativeClassPtr, nameof (Pitch));
        TopdownCameraState.LerpVariables.NativeMethodInfoPtr_SmoothLerp_Public_Static_LerpVariables_byref_LerpVariables_byref_LerpVariables_byref_LerpVariables_Single_Boolean_byref_LerpLambdaVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopdownCameraState.LerpVariables>.NativeClassPtr, 100663839);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TopdownCameraState.LerpVariables>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
