// Decompiled with JetBrains decompiler
// Type: ProjectM.OrbitCameraState
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
  public struct OrbitCameraState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AnchorHeightOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_AutomaticRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseCustomLookAtTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomLookAtTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FollowTargetObjectRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverTheShoulderOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Current;
    [FieldOffset(0)]
    public float AnchorHeightOffset;
    [FieldOffset(4)]
    public float AutomaticRotationSpeed;
    [FieldOffset(8)]
    public bool UseCustomLookAtTarget;
    [FieldOffset(12)]
    public Entity CustomLookAtTarget;
    [FieldOffset(20)]
    public bool FollowTargetObjectRotation;
    [FieldOffset(24)]
    public Entity LastTargetEntity;
    [FieldOffset(32)]
    public float OverTheShoulderOffset;
    [FieldOffset(36)]
    public OrbitCameraState.LerpVariables LastTarget;
    [FieldOffset(76)]
    public OrbitCameraState.LerpVariables Target;
    [FieldOffset(116)]
    public OrbitCameraState.LerpVariables Current;

    static OrbitCameraState()
    {
      Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (OrbitCameraState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr);
      OrbitCameraState.NativeFieldInfoPtr_AnchorHeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr, nameof (AnchorHeightOffset));
      OrbitCameraState.NativeFieldInfoPtr_AutomaticRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr, nameof (AutomaticRotationSpeed));
      OrbitCameraState.NativeFieldInfoPtr_UseCustomLookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr, nameof (UseCustomLookAtTarget));
      OrbitCameraState.NativeFieldInfoPtr_CustomLookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr, nameof (CustomLookAtTarget));
      OrbitCameraState.NativeFieldInfoPtr_FollowTargetObjectRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr, nameof (FollowTargetObjectRotation));
      OrbitCameraState.NativeFieldInfoPtr_LastTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr, nameof (LastTargetEntity));
      OrbitCameraState.NativeFieldInfoPtr_OverTheShoulderOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr, nameof (OverTheShoulderOffset));
      OrbitCameraState.NativeFieldInfoPtr_LastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr, nameof (LastTarget));
      OrbitCameraState.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr, nameof (Target));
      OrbitCameraState.NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr, nameof (Current));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LerpVariables
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_OrbitDistance;
      private static readonly System.IntPtr NativeFieldInfoPtr_OrbitYaw;
      private static readonly System.IntPtr NativeFieldInfoPtr_OrbitPitch;
      private static readonly System.IntPtr NativeFieldInfoPtr_AnchorPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_AnchorRotation;
      private static readonly System.IntPtr NativeMethodInfoPtr_SmoothLerp_Public_Static_LerpVariables_byref_LerpVariables_byref_LerpVariables_byref_LerpVariables_Single_byref_LerpLambdaVars_0;
      [FieldOffset(0)]
      public float OrbitDistance;
      [FieldOffset(4)]
      public float OrbitYaw;
      [FieldOffset(8)]
      public float OrbitPitch;
      [FieldOffset(12)]
      public float3 AnchorPosition;
      [FieldOffset(24)]
      public quaternion AnchorRotation;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 722717, RefRangeEnd = 722718, XrefRangeStart = 722706, XrefRangeEnd = 722717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe OrbitCameraState.LerpVariables SmoothLerp(
        [In] ref OrbitCameraState.LerpVariables current,
        [In] ref OrbitCameraState.LerpVariables lastTarget,
        [In] ref OrbitCameraState.LerpVariables target,
        float deltaTime,
        [In] ref OrbitCamera.LerpLambdaVars lerpLambdas)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref current;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref lerpLambdas;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OrbitCameraState.LerpVariables.NativeMethodInfoPtr_SmoothLerp_Public_Static_LerpVariables_byref_LerpVariables_byref_LerpVariables_byref_LerpVariables_Single_byref_LerpLambdaVars_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(OrbitCameraState.LerpVariables*) IL2CPP.il2cpp_object_unbox(num);
      }

      static LerpVariables()
      {
        Il2CppClassPointerStore<OrbitCameraState.LerpVariables>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrbitCameraState>.NativeClassPtr, nameof (LerpVariables));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrbitCameraState.LerpVariables>.NativeClassPtr);
        OrbitCameraState.LerpVariables.NativeFieldInfoPtr_OrbitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState.LerpVariables>.NativeClassPtr, nameof (OrbitDistance));
        OrbitCameraState.LerpVariables.NativeFieldInfoPtr_OrbitYaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState.LerpVariables>.NativeClassPtr, nameof (OrbitYaw));
        OrbitCameraState.LerpVariables.NativeFieldInfoPtr_OrbitPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState.LerpVariables>.NativeClassPtr, nameof (OrbitPitch));
        OrbitCameraState.LerpVariables.NativeFieldInfoPtr_AnchorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState.LerpVariables>.NativeClassPtr, nameof (AnchorPosition));
        OrbitCameraState.LerpVariables.NativeFieldInfoPtr_AnchorRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraState.LerpVariables>.NativeClassPtr, nameof (AnchorRotation));
        OrbitCameraState.LerpVariables.NativeMethodInfoPtr_SmoothLerp_Public_Static_LerpVariables_byref_LerpVariables_byref_LerpVariables_byref_LerpVariables_Single_byref_LerpLambdaVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCameraState.LerpVariables>.NativeClassPtr, 100663836);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OrbitCameraState.LerpVariables>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
