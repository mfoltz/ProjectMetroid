// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.SmurfProjectile_DataClient
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SmurfProjectile_DataClient
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdateSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceState;
    [FieldOffset(0)]
    public SequenceGUID UpdateSequence;
    [FieldOffset(4)]
    public SequenceState SequenceState;

    static SmurfProjectile_DataClient()
    {
      Il2CppClassPointerStore<SmurfProjectile_DataClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (SmurfProjectile_DataClient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmurfProjectile_DataClient>.NativeClassPtr);
      SmurfProjectile_DataClient.NativeFieldInfoPtr_UpdateSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfProjectile_DataClient>.NativeClassPtr, nameof (UpdateSequence));
      SmurfProjectile_DataClient.NativeFieldInfoPtr_SequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfProjectile_DataClient>.NativeClassPtr, nameof (SequenceState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SmurfProjectile_DataClient>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
