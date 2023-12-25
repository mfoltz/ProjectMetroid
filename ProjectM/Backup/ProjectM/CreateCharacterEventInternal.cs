// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateCharacterEventInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateCharacterEventInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FromCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_Customization;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Done;
    [FieldOffset(0)]
    public FromCharacter FromCharacter;
    [FieldOffset(16)]
    public CustomizationFeatures Customization;
    [FieldOffset(24)]
    public Entity FadeOutEntity;
    [FieldOffset(32)]
    public double SpawnTime;
    [FieldOffset(40)]
    public bool Done;

    static CreateCharacterEventInternal()
    {
      Il2CppClassPointerStore<CreateCharacterEventInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateCharacterEventInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateCharacterEventInternal>.NativeClassPtr);
      CreateCharacterEventInternal.NativeFieldInfoPtr_FromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEventInternal>.NativeClassPtr, nameof (FromCharacter));
      CreateCharacterEventInternal.NativeFieldInfoPtr_Customization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEventInternal>.NativeClassPtr, nameof (Customization));
      CreateCharacterEventInternal.NativeFieldInfoPtr_FadeOutEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEventInternal>.NativeClassPtr, nameof (FadeOutEntity));
      CreateCharacterEventInternal.NativeFieldInfoPtr_SpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEventInternal>.NativeClassPtr, nameof (SpawnTime));
      CreateCharacterEventInternal.NativeFieldInfoPtr_Done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEventInternal>.NativeClassPtr, nameof (Done));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateCharacterEventInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
