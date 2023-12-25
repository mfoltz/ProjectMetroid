// Decompiled with JetBrains decompiler
// Type: ProjectM.TheMonsterGeneratorActiveBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TheMonsterGeneratorActiveBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneratorEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransitionGeneratorIfActuallySpawned;
    [FieldOffset(0)]
    public Entity GeneratorEntity;
    [FieldOffset(8)]
    public bool TransitionGeneratorIfActuallySpawned;

    static TheMonsterGeneratorActiveBuff()
    {
      Il2CppClassPointerStore<TheMonsterGeneratorActiveBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TheMonsterGeneratorActiveBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheMonsterGeneratorActiveBuff>.NativeClassPtr);
      TheMonsterGeneratorActiveBuff.NativeFieldInfoPtr_GeneratorEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorActiveBuff>.NativeClassPtr, nameof (GeneratorEntity));
      TheMonsterGeneratorActiveBuff.NativeFieldInfoPtr_TransitionGeneratorIfActuallySpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorActiveBuff>.NativeClassPtr, nameof (TransitionGeneratorIfActuallySpawned));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TheMonsterGeneratorActiveBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
