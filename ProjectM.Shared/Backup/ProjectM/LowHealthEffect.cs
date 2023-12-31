// Decompiled with JetBrains decompiler
// Type: ProjectM.LowHealthEffect
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LowHealthEffect
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LowHealthSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_LowHealthSequenceInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_LowHealthSequenceStartFactor;
    [FieldOffset(0)]
    public SequenceGUID LowHealthSequenceGuid;
    [FieldOffset(4)]
    public SequenceState LowHealthSequenceInstance;
    [FieldOffset(12)]
    public float LowHealthSequenceStartFactor;

    static LowHealthEffect()
    {
      Il2CppClassPointerStore<LowHealthEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (LowHealthEffect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowHealthEffect>.NativeClassPtr);
      LowHealthEffect.NativeFieldInfoPtr_LowHealthSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowHealthEffect>.NativeClassPtr, nameof (LowHealthSequenceGuid));
      LowHealthEffect.NativeFieldInfoPtr_LowHealthSequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowHealthEffect>.NativeClassPtr, nameof (LowHealthSequenceInstance));
      LowHealthEffect.NativeFieldInfoPtr_LowHealthSequenceStartFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowHealthEffect>.NativeClassPtr, nameof (LowHealthSequenceStartFactor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LowHealthEffect>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
