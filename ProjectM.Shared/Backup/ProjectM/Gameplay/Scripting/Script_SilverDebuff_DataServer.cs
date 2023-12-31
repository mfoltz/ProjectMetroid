// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SilverDebuff_DataServer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_SilverDebuff_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageParameters;
    private static readonly System.IntPtr NativeFieldInfoPtr_LethalTicksBeforeDeath;
    [FieldOffset(0)]
    public DealDamageParameters DamageParameters;
    [FieldOffset(112)]
    public int LethalTicksBeforeDeath;

    static Script_SilverDebuff_DataServer()
    {
      Il2CppClassPointerStore<Script_SilverDebuff_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SilverDebuff_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SilverDebuff_DataServer>.NativeClassPtr);
      Script_SilverDebuff_DataServer.NativeFieldInfoPtr_DamageParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SilverDebuff_DataServer>.NativeClassPtr, nameof (DamageParameters));
      Script_SilverDebuff_DataServer.NativeFieldInfoPtr_LethalTicksBeforeDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SilverDebuff_DataServer>.NativeClassPtr, nameof (LethalTicksBeforeDeath));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_SilverDebuff_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
