// Decompiled with JetBrains decompiler
// Type: ProjectM.AiDamageTakenEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AiDamageTakenEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    [FieldOffset(0)]
    public float Amount;
    [FieldOffset(4)]
    public Entity Target;
    [FieldOffset(12)]
    public Entity Source;
    [FieldOffset(24)]
    public double Time;

    static AiDamageTakenEvent()
    {
      Il2CppClassPointerStore<AiDamageTakenEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AiDamageTakenEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiDamageTakenEvent>.NativeClassPtr);
      AiDamageTakenEvent.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiDamageTakenEvent>.NativeClassPtr, nameof (Amount));
      AiDamageTakenEvent.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiDamageTakenEvent>.NativeClassPtr, nameof (Target));
      AiDamageTakenEvent.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiDamageTakenEvent>.NativeClassPtr, nameof (Source));
      AiDamageTakenEvent.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiDamageTakenEvent>.NativeClassPtr, nameof (Time));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiDamageTakenEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
