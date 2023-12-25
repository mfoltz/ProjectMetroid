// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Spectral_Empower_DataClient
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Spectral_Empower_DataClient
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EmpowerSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_EmpowerSequenceState;
    [FieldOffset(0)]
    public SequenceGUID EmpowerSequence;
    [FieldOffset(4)]
    public SequenceState EmpowerSequenceState;

    static Script_Spectral_Empower_DataClient()
    {
      Il2CppClassPointerStore<Script_Spectral_Empower_DataClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Spectral_Empower_DataClient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Spectral_Empower_DataClient>.NativeClassPtr);
      Script_Spectral_Empower_DataClient.NativeFieldInfoPtr_EmpowerSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Spectral_Empower_DataClient>.NativeClassPtr, nameof (EmpowerSequence));
      Script_Spectral_Empower_DataClient.NativeFieldInfoPtr_EmpowerSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Spectral_Empower_DataClient>.NativeClassPtr, nameof (EmpowerSequenceState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Spectral_Empower_DataClient>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
