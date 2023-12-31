// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_GarlicAreaDebuff_DataServer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_GarlicAreaDebuff_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicStacksPerTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeInterval;
    private static readonly System.IntPtr NativeFieldInfoPtr_Timer;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamagePerTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_DecreaseTimeInterval;
    private static readonly System.IntPtr NativeFieldInfoPtr_DecreaseDynamicStacksPerTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_GarlicFever;
    [FieldOffset(0)]
    public float DynamicStacks;
    [FieldOffset(4)]
    public float DynamicStacksPerTick;
    [FieldOffset(8)]
    public float TimeInterval;
    [FieldOffset(12)]
    public float Timer;
    [FieldOffset(16)]
    public float DamagePerTick;
    [FieldOffset(20)]
    public float DecreaseTimeInterval;
    [FieldOffset(24)]
    public float DecreaseDynamicStacksPerTick;
    [FieldOffset(28)]
    public PrefabGUID GarlicFever;

    static Script_GarlicAreaDebuff_DataServer()
    {
      Il2CppClassPointerStore<Script_GarlicAreaDebuff_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Gameplay.Scripting", nameof (Script_GarlicAreaDebuff_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_GarlicAreaDebuff_DataServer>.NativeClassPtr);
      Script_GarlicAreaDebuff_DataServer.NativeFieldInfoPtr_DynamicStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicAreaDebuff_DataServer>.NativeClassPtr, nameof (DynamicStacks));
      Script_GarlicAreaDebuff_DataServer.NativeFieldInfoPtr_DynamicStacksPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicAreaDebuff_DataServer>.NativeClassPtr, nameof (DynamicStacksPerTick));
      Script_GarlicAreaDebuff_DataServer.NativeFieldInfoPtr_TimeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicAreaDebuff_DataServer>.NativeClassPtr, nameof (TimeInterval));
      Script_GarlicAreaDebuff_DataServer.NativeFieldInfoPtr_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicAreaDebuff_DataServer>.NativeClassPtr, nameof (Timer));
      Script_GarlicAreaDebuff_DataServer.NativeFieldInfoPtr_DamagePerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicAreaDebuff_DataServer>.NativeClassPtr, nameof (DamagePerTick));
      Script_GarlicAreaDebuff_DataServer.NativeFieldInfoPtr_DecreaseTimeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicAreaDebuff_DataServer>.NativeClassPtr, nameof (DecreaseTimeInterval));
      Script_GarlicAreaDebuff_DataServer.NativeFieldInfoPtr_DecreaseDynamicStacksPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicAreaDebuff_DataServer>.NativeClassPtr, nameof (DecreaseDynamicStacksPerTick));
      Script_GarlicAreaDebuff_DataServer.NativeFieldInfoPtr_GarlicFever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicAreaDebuff_DataServer>.NativeClassPtr, nameof (GarlicFever));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_GarlicAreaDebuff_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
