using DomainName.Application.Abstractions.Application.Providers;

using GTA;
using GTA.Math;

namespace DomainName.Application.Providers;

/// <summary>
/// Represents the implementation of the <see cref="IAudioProvider"/> interface.
/// </summary>
internal sealed class AudioProvider : IAudioProvider
{
	public void PlayMusic(string musicFile) => Audio.PlayMusic(musicFile);

	public void StopMusic(string musicFile) => Audio.StopMusic(musicFile);

	public int PlaySoundAt(Entity entity, string soundFile) => Audio.PlaySoundAt(entity, soundFile);

	public int PlaySoundAt(Entity entity, string soundFile, string soundSet) => Audio.PlaySoundAt(entity, soundFile, soundSet);

	public int PlaySoundAt(Vector3 position, string soundFile) => Audio.PlaySoundAt(position, soundFile);

	public int PlaySoundAt(Vector3 position, string soundFile, string soundSet) => Audio.PlaySoundAt(position, soundFile, soundSet);

	public int PlaySoundFrontend(string soundFile) => Audio.PlaySoundFrontend(soundFile);

	public int PlaySoundFrontend(string soundFile, string soundSet) => Audio.PlaySoundFrontend(soundFile, soundSet);

	public void StopSound(int id) => Audio.StopSound(id);

	public void ReleaseSound(int id) => Audio.ReleaseSound(id);

	public bool HasSoundFinished(int id) => Audio.HasSoundFinished(id);

	public void SetAudioFlag(AudioFlags flag, bool toggle) => Audio.SetAudioFlag(flag, toggle);
}
