// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SCTChatOnSpawn_Buffer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_SCTChatOnSpawn_Buffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    [FieldOffset(0)]
    public LocalizationKey Text;
    [FieldOffset(16)]
    public int Weight;

    static Script_SCTChatOnSpawn_Buffer()
    {
      Il2CppClassPointerStore<Script_SCTChatOnSpawn_Buffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SCTChatOnSpawn_Buffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SCTChatOnSpawn_Buffer>.NativeClassPtr);
      Script_SCTChatOnSpawn_Buffer.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnSpawn_Buffer>.NativeClassPtr, nameof (Text));
      Script_SCTChatOnSpawn_Buffer.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnSpawn_Buffer>.NativeClassPtr, nameof (Weight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_SCTChatOnSpawn_Buffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
