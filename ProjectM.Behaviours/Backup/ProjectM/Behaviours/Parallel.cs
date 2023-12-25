// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.Parallel
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Parallel
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SuccessCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FailCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Terminated;
    private static readonly System.IntPtr NativeFieldInfoPtr_SuccessPolicy;
    private static readonly System.IntPtr NativeFieldInfoPtr_FailPolicy;
    [FieldOffset(0)]
    public PrivateField<int> SuccessCount;
    [FieldOffset(4)]
    public PrivateField<int> FailCount;
    [FieldOffset(8)]
    public PrivateField<bool> Terminated;
    [FieldOffset(12)]
    public ParallelPolicy SuccessPolicy;
    [FieldOffset(16)]
    public ParallelPolicy FailPolicy;

    static Parallel()
    {
      Il2CppClassPointerStore<Parallel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (Parallel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parallel>.NativeClassPtr);
      Parallel.NativeFieldInfoPtr_SuccessCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parallel>.NativeClassPtr, nameof (SuccessCount));
      Parallel.NativeFieldInfoPtr_FailCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parallel>.NativeClassPtr, nameof (FailCount));
      Parallel.NativeFieldInfoPtr_Terminated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parallel>.NativeClassPtr, nameof (Terminated));
      Parallel.NativeFieldInfoPtr_SuccessPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parallel>.NativeClassPtr, nameof (SuccessPolicy));
      Parallel.NativeFieldInfoPtr_FailPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parallel>.NativeClassPtr, nameof (FailPolicy));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Parallel>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
