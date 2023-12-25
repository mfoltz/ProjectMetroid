// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.SCTChatOnAggro_Entry
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct SCTChatOnAggro_Entry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    [FieldOffset(0)]
    public LocalizationKey Text;
    [FieldOffset(16)]
    public int Weight;

    static SCTChatOnAggro_Entry()
    {
      Il2CppClassPointerStore<SCTChatOnAggro_Entry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (SCTChatOnAggro_Entry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SCTChatOnAggro_Entry>.NativeClassPtr);
      SCTChatOnAggro_Entry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTChatOnAggro_Entry>.NativeClassPtr, nameof (Text));
      SCTChatOnAggro_Entry.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTChatOnAggro_Entry>.NativeClassPtr, nameof (Weight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SCTChatOnAggro_Entry>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
