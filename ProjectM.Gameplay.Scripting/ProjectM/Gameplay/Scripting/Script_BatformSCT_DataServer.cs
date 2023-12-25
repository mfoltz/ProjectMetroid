// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_BatformSCT_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_BatformSCT_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FailText;
    [FieldOffset(0)]
    public AssetGuid FailText;

    static Script_BatformSCT_DataServer()
    {
      Il2CppClassPointerStore<Script_BatformSCT_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_BatformSCT_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BatformSCT_DataServer>.NativeClassPtr);
      Script_BatformSCT_DataServer.NativeFieldInfoPtr_FailText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BatformSCT_DataServer>.NativeClassPtr, nameof (FailText));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_BatformSCT_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
