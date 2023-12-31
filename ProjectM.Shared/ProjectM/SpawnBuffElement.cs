// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnBuffElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnBuffElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Kind;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    [FieldOffset(0)]
    public SpawnBuffKind Kind;
    [FieldOffset(4)]
    public PrefabGUID Buff;
    [FieldOffset(8)]
    public float Weight;

    static SpawnBuffElement()
    {
      Il2CppClassPointerStore<SpawnBuffElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnBuffElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnBuffElement>.NativeClassPtr);
      SpawnBuffElement.NativeFieldInfoPtr_Kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnBuffElement>.NativeClassPtr, nameof (Kind));
      SpawnBuffElement.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnBuffElement>.NativeClassPtr, nameof (Buff));
      SpawnBuffElement.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnBuffElement>.NativeClassPtr, nameof (Weight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnBuffElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
