// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantInjuredChance
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServantInjuredChance
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Injured_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Injured_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_Injured_Type;
    [FieldOffset(0)]
    public float Injured_Weight;
    [FieldOffset(4)]
    public float Injured_Time;
    [FieldOffset(8)]
    public PrefabGUID Injured_Type;

    static ServantInjuredChance()
    {
      Il2CppClassPointerStore<ServantInjuredChance>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServantInjuredChance));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantInjuredChance>.NativeClassPtr);
      ServantInjuredChance.NativeFieldInfoPtr_Injured_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInjuredChance>.NativeClassPtr, nameof (Injured_Weight));
      ServantInjuredChance.NativeFieldInfoPtr_Injured_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInjuredChance>.NativeClassPtr, nameof (Injured_Time));
      ServantInjuredChance.NativeFieldInfoPtr_Injured_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInjuredChance>.NativeClassPtr, nameof (Injured_Type));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantInjuredChance>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
