// Decompiled with JetBrains decompiler
// Type: ProjectM.FreeCameraState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FreeCameraState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticCamera;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Current;
    private static readonly System.IntPtr NativeFieldInfoPtr_MovementSpeed;
    [FieldOffset(0)]
    public bool StaticCamera;
    [FieldOffset(4)]
    public FreeCameraState.LerpVariables LastTarget;
    [FieldOffset(24)]
    public FreeCameraState.LerpVariables Target;
    [FieldOffset(44)]
    public FreeCameraState.LerpVariables Current;
    [FieldOffset(64)]
    public float MovementSpeed;

    static FreeCameraState()
    {
      Il2CppClassPointerStore<FreeCameraState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FreeCameraState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeCameraState>.NativeClassPtr);
      FreeCameraState.NativeFieldInfoPtr_StaticCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraState>.NativeClassPtr, nameof (StaticCamera));
      FreeCameraState.NativeFieldInfoPtr_LastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraState>.NativeClassPtr, nameof (LastTarget));
      FreeCameraState.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraState>.NativeClassPtr, nameof (Target));
      FreeCameraState.NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraState>.NativeClassPtr, nameof (Current));
      FreeCameraState.NativeFieldInfoPtr_MovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraState>.NativeClassPtr, nameof (MovementSpeed));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FreeCameraState>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LerpVariables
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Yaw;
      private static readonly System.IntPtr NativeFieldInfoPtr_Pitch;
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeMethodInfoPtr_SmoothLerp_Public_Static_LerpVariables_byref_LerpVariables_byref_LerpVariables_byref_LerpVariables_Single_byref_LerpLambdaVars_0;
      [FieldOffset(0)]
      public float Yaw;
      [FieldOffset(4)]
      public float Pitch;
      [FieldOffset(8)]
      public float3 Position;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 722630, RefRangeEnd = 722631, XrefRangeStart = 722623, XrefRangeEnd = 722630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe FreeCameraState.LerpVariables SmoothLerp(
        [In] ref FreeCameraState.LerpVariables current,
        [In] ref FreeCameraState.LerpVariables lastTarget,
        [In] ref FreeCameraState.LerpVariables target,
        float deltaTime,
        [In] ref FreeCamera.LerpLambdaVars lerpLambdas)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref current;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref lerpLambdas;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FreeCameraState.LerpVariables.NativeMethodInfoPtr_SmoothLerp_Public_Static_LerpVariables_byref_LerpVariables_byref_LerpVariables_byref_LerpVariables_Single_byref_LerpLambdaVars_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(FreeCameraState.LerpVariables*) IL2CPP.il2cpp_object_unbox(num);
      }

      static LerpVariables()
      {
        Il2CppClassPointerStore<FreeCameraState.LerpVariables>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FreeCameraState>.NativeClassPtr, nameof (LerpVariables));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeCameraState.LerpVariables>.NativeClassPtr);
        FreeCameraState.LerpVariables.NativeFieldInfoPtr_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraState.LerpVariables>.NativeClassPtr, nameof (Yaw));
        FreeCameraState.LerpVariables.NativeFieldInfoPtr_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraState.LerpVariables>.NativeClassPtr, nameof (Pitch));
        FreeCameraState.LerpVariables.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraState.LerpVariables>.NativeClassPtr, nameof (Position));
        FreeCameraState.LerpVariables.NativeMethodInfoPtr_SmoothLerp_Public_Static_LerpVariables_byref_LerpVariables_byref_LerpVariables_byref_LerpVariables_Single_byref_LerpLambdaVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraState.LerpVariables>.NativeClassPtr, 100663812);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FreeCameraState.LerpVariables>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
