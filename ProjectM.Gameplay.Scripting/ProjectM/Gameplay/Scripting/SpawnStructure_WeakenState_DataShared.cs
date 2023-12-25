// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.SpawnStructure_WeakenState_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnStructure_WeakenState_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageTakenListener;
    [FieldOffset(0)]
    public ListenerId OnDamageTakenListener;

    static SpawnStructure_WeakenState_DataShared()
    {
      Il2CppClassPointerStore<SpawnStructure_WeakenState_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (SpawnStructure_WeakenState_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnStructure_WeakenState_DataShared>.NativeClassPtr);
      SpawnStructure_WeakenState_DataShared.NativeFieldInfoPtr_OnDamageTakenListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnStructure_WeakenState_DataShared>.NativeClassPtr, nameof (OnDamageTakenListener));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnStructure_WeakenState_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
