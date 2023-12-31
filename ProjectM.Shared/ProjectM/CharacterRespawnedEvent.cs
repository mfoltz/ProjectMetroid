// Decompiled with JetBrains decompiler
// Type: ProjectM.CharacterRespawnedEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CharacterRespawnedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    [FieldOffset(0)]
    public Entity Entity;

    static CharacterRespawnedEvent()
    {
      Il2CppClassPointerStore<CharacterRespawnedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CharacterRespawnedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterRespawnedEvent>.NativeClassPtr);
      CharacterRespawnedEvent.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterRespawnedEvent>.NativeClassPtr, nameof (Entity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterRespawnedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
