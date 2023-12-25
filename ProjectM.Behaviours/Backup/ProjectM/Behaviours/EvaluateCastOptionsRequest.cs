// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.EvaluateCastOptionsRequest
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EvaluateCastOptionsRequest
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Input;
    private static readonly System.IntPtr NativeFieldInfoPtr_InternalState;
    private static readonly System.IntPtr NativeFieldInfoPtr_Response;
    private static readonly System.IntPtr NativeFieldInfoPtr_SuccessFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_Destroy;
    [FieldOffset(0)]
    public EvaluateCastOptionsRequestInput Input;
    [FieldOffset(16)]
    public EvaluateCastOptionsRequestInternalState InternalState;
    [FieldOffset(44)]
    public EvaluateCastOptionsRequestResponse Response;
    [FieldOffset(64)]
    public int SuccessFrame;
    [FieldOffset(68)]
    public EvaluateCastOptionsRequestStatus Status;
    [FieldOffset(72)]
    public bool Destroy;

    static EvaluateCastOptionsRequest()
    {
      Il2CppClassPointerStore<EvaluateCastOptionsRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (EvaluateCastOptionsRequest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptionsRequest>.NativeClassPtr);
      EvaluateCastOptionsRequest.NativeFieldInfoPtr_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequest>.NativeClassPtr, nameof (Input));
      EvaluateCastOptionsRequest.NativeFieldInfoPtr_InternalState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequest>.NativeClassPtr, nameof (InternalState));
      EvaluateCastOptionsRequest.NativeFieldInfoPtr_Response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequest>.NativeClassPtr, nameof (Response));
      EvaluateCastOptionsRequest.NativeFieldInfoPtr_SuccessFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequest>.NativeClassPtr, nameof (SuccessFrame));
      EvaluateCastOptionsRequest.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequest>.NativeClassPtr, nameof (Status));
      EvaluateCastOptionsRequest.NativeFieldInfoPtr_Destroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequest>.NativeClassPtr, nameof (Destroy));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptionsRequest>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
