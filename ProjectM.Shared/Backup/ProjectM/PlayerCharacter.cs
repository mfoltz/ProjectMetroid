// Decompiled with JetBrains decompiler
// Type: ProjectM.PlayerCharacter
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlayerCharacter
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmartClanName;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastValidPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserEntity;
    [FieldOffset(0)]
    public FixedString64 Name;
    [FieldOffset(64)]
    public FixedString32 SmartClanName;
    [FieldOffset(96)]
    public float2 LastValidPosition;
    [FieldOffset(104)]
    public Entity UserEntity;

    static PlayerCharacter()
    {
      Il2CppClassPointerStore<PlayerCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PlayerCharacter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCharacter>.NativeClassPtr);
      PlayerCharacter.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCharacter>.NativeClassPtr, nameof (Name));
      PlayerCharacter.NativeFieldInfoPtr_SmartClanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCharacter>.NativeClassPtr, nameof (SmartClanName));
      PlayerCharacter.NativeFieldInfoPtr_LastValidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCharacter>.NativeClassPtr, nameof (LastValidPosition));
      PlayerCharacter.NativeFieldInfoPtr_UserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCharacter>.NativeClassPtr, nameof (UserEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerCharacter>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
