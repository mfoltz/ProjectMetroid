// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ApplyExclusiveSiegeBuff_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_ApplyExclusiveSiegeBuff_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NewBuffEntity;
    [FieldOffset(0)]
    public PrefabGUID NewBuffEntity;

    static Script_ApplyExclusiveSiegeBuff_DataServer()
    {
      Il2CppClassPointerStore<Script_ApplyExclusiveSiegeBuff_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ApplyExclusiveSiegeBuff_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ApplyExclusiveSiegeBuff_DataServer>.NativeClassPtr);
      Script_ApplyExclusiveSiegeBuff_DataServer.NativeFieldInfoPtr_NewBuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyExclusiveSiegeBuff_DataServer>.NativeClassPtr, nameof (NewBuffEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ApplyExclusiveSiegeBuff_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
