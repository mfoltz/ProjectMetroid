// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.CreateCharacterCacheData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateCharacterCacheData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GenderIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkintoneIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FaceIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EyeColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairStyleIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeaturesIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_AccessoriesIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public byte GenderIndex;
    [FieldOffset(1)]
    public byte SkintoneIndex;
    [FieldOffset(2)]
    public byte FaceIndex;
    [FieldOffset(3)]
    public byte EyeColorIndex;
    [FieldOffset(4)]
    public byte HairStyleIndex;
    [FieldOffset(5)]
    public byte HairColorIndex;
    [FieldOffset(6)]
    public byte FeaturesIndex;
    [FieldOffset(7)]
    public byte AccessoriesIndex;
    [FieldOffset(8)]
    public FixedString64 Name;

    static CreateCharacterCacheData()
    {
      Il2CppClassPointerStore<CreateCharacterCacheData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (CreateCharacterCacheData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateCharacterCacheData>.NativeClassPtr);
      CreateCharacterCacheData.NativeFieldInfoPtr_GenderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterCacheData>.NativeClassPtr, nameof (GenderIndex));
      CreateCharacterCacheData.NativeFieldInfoPtr_SkintoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterCacheData>.NativeClassPtr, nameof (SkintoneIndex));
      CreateCharacterCacheData.NativeFieldInfoPtr_FaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterCacheData>.NativeClassPtr, nameof (FaceIndex));
      CreateCharacterCacheData.NativeFieldInfoPtr_EyeColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterCacheData>.NativeClassPtr, nameof (EyeColorIndex));
      CreateCharacterCacheData.NativeFieldInfoPtr_HairStyleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterCacheData>.NativeClassPtr, nameof (HairStyleIndex));
      CreateCharacterCacheData.NativeFieldInfoPtr_HairColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterCacheData>.NativeClassPtr, nameof (HairColorIndex));
      CreateCharacterCacheData.NativeFieldInfoPtr_FeaturesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterCacheData>.NativeClassPtr, nameof (FeaturesIndex));
      CreateCharacterCacheData.NativeFieldInfoPtr_AccessoriesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterCacheData>.NativeClassPtr, nameof (AccessoriesIndex));
      CreateCharacterCacheData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterCacheData>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateCharacterCacheData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
