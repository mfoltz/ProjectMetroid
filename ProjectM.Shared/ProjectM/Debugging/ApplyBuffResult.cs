// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.ApplyBuffResult
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ApplyBuffResult
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff3;
    private static readonly System.IntPtr NativeFieldInfoPtr_Result0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Result1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Result2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Result3;
    [FieldOffset(0)]
    public PrefabGUID Buff0;
    [FieldOffset(4)]
    public PrefabGUID Buff1;
    [FieldOffset(8)]
    public PrefabGUID Buff2;
    [FieldOffset(12)]
    public PrefabGUID Buff3;
    [FieldOffset(16)]
    public bool Result0;
    [FieldOffset(17)]
    public bool Result1;
    [FieldOffset(18)]
    public bool Result2;
    [FieldOffset(19)]
    public bool Result3;

    static ApplyBuffResult()
    {
      Il2CppClassPointerStore<ApplyBuffResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (ApplyBuffResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyBuffResult>.NativeClassPtr);
      ApplyBuffResult.NativeFieldInfoPtr_Buff0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffResult>.NativeClassPtr, nameof (Buff0));
      ApplyBuffResult.NativeFieldInfoPtr_Buff1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffResult>.NativeClassPtr, nameof (Buff1));
      ApplyBuffResult.NativeFieldInfoPtr_Buff2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffResult>.NativeClassPtr, nameof (Buff2));
      ApplyBuffResult.NativeFieldInfoPtr_Buff3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffResult>.NativeClassPtr, nameof (Buff3));
      ApplyBuffResult.NativeFieldInfoPtr_Result0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffResult>.NativeClassPtr, nameof (Result0));
      ApplyBuffResult.NativeFieldInfoPtr_Result1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffResult>.NativeClassPtr, nameof (Result1));
      ApplyBuffResult.NativeFieldInfoPtr_Result2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffResult>.NativeClassPtr, nameof (Result2));
      ApplyBuffResult.NativeFieldInfoPtr_Result3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffResult>.NativeClassPtr, nameof (Result3));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplyBuffResult>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
