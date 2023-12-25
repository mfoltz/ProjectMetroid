// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.ExampleScript_DataClient
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ExampleScript_DataClient
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientValue;
    [FieldOffset(0)]
    public FixedString128 ClientValue;

    static ExampleScript_DataClient()
    {
      Il2CppClassPointerStore<ExampleScript_DataClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (ExampleScript_DataClient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExampleScript_DataClient>.NativeClassPtr);
      ExampleScript_DataClient.NativeFieldInfoPtr_ClientValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleScript_DataClient>.NativeClassPtr, nameof (ClientValue));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExampleScript_DataClient>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
